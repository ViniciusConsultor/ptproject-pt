using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using PT.Helper;
using System.Windows.Forms.Design;

namespace PT.Component
{
    [Designer(typeof(ControlDesigner))]  
    public partial class TextBox : DevComponents.DotNetBar.Controls.TextBoxX
    {
         #region "Khai bao bien"
        private bool _AutoComplete;
        private bool _AutoDropdown;        
        private Color _BackColorEven = Color.White;
        private Color _BackColorOdd = Color.White;
        private string _ColumnNameStrings = "";
        private string _ColumnHeaderStrings = "";
        private int _ColumnWidthDefault = 75;
        private string _ColumnWidthStrings = "";
        private int _LinkedColumnIndex;
        private TextBox _LinkedTextBox;
        private int _TotalWidth = 0;
        private string _language = "Language1";
        private int _DataGridViewXHeight = 200;
        private int _DataGridViewXWidth = 300;
        private int _RowsDisPlay = 10;
        private bool _AutoResizeColumn = true;
        private DataTable _DataSource = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX _DataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
        
        private Collection<string> _ColumnNames = new Collection<string>();
        private Collection<string> _ColumnHeaders = new Collection<string>();
        private Collection<int> _ColumnWidths = new Collection<int>();
        #endregion

        public TextBox() : base()
        { }

        public TextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
       
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            _DrawDataGridViewX();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (_DataGridViewX.Focused == false)
                _DataGridViewX.Visible = false;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (_DataSource == null)
                return;                                    
            if (_ColumnNames.Count != 0&& this.Focused==true)
            {
                string sql = string.Format("{0} like '%{1}%'", _ColumnNames[0], this.Text); 
                int a;
                for (a = 1; a <= _ColumnNames.Count - 1; a++)
                {
                    sql += string.Format("OR {0} like '%{1}%'", _ColumnNames[a], this.Text);
                }
                _DataSource.DefaultView.RowFilter = sql;                
               _DataGridViewX_ChangeStyle();
            }
        }       
        //Override lai su kien KeyDown cua TextBox
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            _DataGridViewX_ChangeStyle();
            
            if (e.KeyCode == Keys.Down && _DataGridViewX.RowCount != 0)
            {
                _DataGridViewX.Focus();
                if ((this.Text == "") || (this.Text == string.Empty) || (this.Text == null))
                {
                    _DataGridViewX.CurrentCell = this._DataGridViewX[0, 0];                                   
                }
                else
                {
                    int _intRow = _getItemRow(this.Text);
                    if (_intRow < _DataGridViewX.RowCount - 1)
                        _intRow = _intRow + 1;
                    _DataGridViewX.CurrentCell = this._DataGridViewX[0, _intRow];
                    _DataGridViewX.CurrentCell.Selected = true;
                    
                }
            }
            if (e.KeyCode == Keys.Up && _DataGridViewX.RowCount != 0)
            {
                _DataGridViewX.Focus();
                int _intRow = _getItemRow(this.Text);
                if (_intRow > 0)
                    _intRow = _intRow - 1;
                _DataGridViewX.CurrentCell = this._DataGridViewX[0, _intRow];
                _DataGridViewX.CurrentCell.Selected = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                _DataGridViewX.Visible = false;
                return;
            }
            if (e.KeyCode == Keys.Enter && _DataGridViewX.RowCount != 0)
            {
                if (_DataGridViewX.Focused == false)
                    return;
                if (_DataGridViewX.Rows.Count >0)
                    this.Text = _DataGridViewX.CurrentRow.Cells[0].Value.ToString();                
                _DataGridViewX.Visible = false;
                return;
            }
        }

        //Khoi tao DataGridViewX
        private void _DrawDataGridViewX()
        { 
            if (_DataSource != null)
            {               
                _DataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
                int X = this.Top; 
                int Y = this.Left;
                _DataGridViewX.Top = X + this.Height;
                _DataGridViewX.Name = "TextboxGrid";
                _DataGridViewX.Left = Y;
                _DataGridViewX.BringToFront();
                _DataGridViewX.Height = _DataGridViewXHeight;
                _DataGridViewX.Width = _DataGridViewXWidth;
                _DataGridViewX.DataSource = _DataSource;
                _DataGridViewX.AllowUserToAddRows = false;
                _DataGridViewX.AllowUserToDeleteRows = false;                
                _DataGridViewX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _DataGridViewX.Visible = false;
                _DataGridViewX.RowHeadersVisible = false;
                _DataGridViewX.Refresh();
                _DataGridViewX.CellDoubleClick +=new DataGridViewCellEventHandler(_DataGridViewX_CellDoubleClick);
                _DataGridViewX.KeyDown += new KeyEventHandler(_DataGridViewX_KeyDown);
                _DataGridViewX.Leave +=new EventHandler(_DataGridViewX_Leave);
                try
                {
                    this.TopLevelControl.Controls.Add(_DataGridViewX);
                }
                catch (Exception ex)
                {
                   // Log.Logger.Error("Loi khoi tao DataGriViewX cua component MultiDropDownTextBoxs" + ex);
                }

                //Gan gia tri cua cac column trong DataSource cho mang _ColumnName
                    if ((_DataSource != null || _DataSource.Rows.Count!=0)&&(_ColumnNameStrings!="" || _ColumnNameStrings != null || _ColumnNameStrings!=string.Empty))
                    {
                        foreach (DataColumn  _dc in _DataSource.Columns)
                        {
                            _ColumnNames.Add(_dc.ColumnName);
                        }
                    }
                //Doi ten cac column Header theo ngon ngu duoc chon truoc
                    if ((_DataSource != null || _DataSource.Rows.Count != 0) && (_ColumnHeaderStrings != "" || _ColumnNameStrings != null || _ColumnNameStrings != string.Empty))
                    {
                        foreach (DataColumn _dc in _DataSource.Columns)
                        {
                            if (Utility.ChangeLanguage(_dc.ColumnName,_language) != null)
                            _ColumnHeaders.Add(Utility.ChangeLanguage(_dc.ColumnName,_language));
                        }
                    }
            }
        }
        private void _DataGridViewX_ChangeStyle()
        {
            this.BringToFront();
            _DataGridViewX.BringToFront();
            _DataGridViewX.Visible = true;
            _DataGridViewX.ReadOnly = true;

            if (_DataSource == null)
                return;
            if (_AutoResizeColumn == true)
            {
                _DataGridViewX.AutoResizeColumns();
            }

            if ((_DataSource.Rows.Count != 0) && (_ColumnHeaders.Count != 0))
            {
                for (int i = 0; i < _DataGridViewX.Columns.Count; i++)
                {
                    _DataGridViewX.Columns[i].HeaderText = _ColumnHeaders[i].ToString();
                }
            }
            if ((_DataSource.Rows.Count != 0) && (_ColumnWidths.Count != 0))
            {
                for (int j = 0; j < _DataGridViewX.Columns.Count; j++)
                {
                    _DataGridViewX.Columns[j].Width = _ColumnWidths[j];
                }
            }
            else if (_DataGridViewX.ColumnCount != 0)
            {
                _DataGridViewX.Columns[0].Width = this.Width;
            }

            //Thay doi kich thuoc cua Grid
            if (_DataSource.Rows.Count != 0 && _DataGridViewX.Rows.Count != 0)
            {
                int GridHeigth = 0;
                if (_DataSource.Rows.Count > _RowsDisPlay)
                    GridHeigth = _DataGridViewX.Rows[0].Height * (_RowsDisPlay + 1);
                else
                    GridHeigth = _DataGridViewX.Rows[0].Height * (_DataGridViewX.Rows.Count + 1);

                _DataGridViewX.Height = GridHeigth;
            }
            //if (_DataGridViewX.Rows.Count > 1)
            //    _DataGridViewX.Rows[(int)_DataGridViewX.CurrentRow.Index].Selected = false;

            //Cuon con tro den dong dau tien
            int _intRow = 0;
            _intRow = _getItemRow(this.Text);
            if (_intRow != 0)
                _DataGridViewX.FirstDisplayedScrollingRowIndex = _intRow;

            //Thay doi vi tri hien thi cua Grid
            Point X = this.Location;
            //Point _x = this.PointToScreen(this.TopLevelControl.Location);
            Point _x = this.PointToScreen(new Point(0, 0));
            Point _thisPoint = new Point(this.Location.X, this.Location.Y);
            Point _topLevel = new Point(this.TopLevelControl.Location.X, this.TopLevelControl.Location.Y);
            
            //int _parentH = this.Parent.Height;
            //int _parentW = this.Parent.Width;
            //int _X = this.Location.X;
            //int _Y = this.Location.Y;
            //if (_DataGridViewX.Height + _Y > _parentH)
            //    _DataGridViewX.Top = _Y - _DataGridViewX.Height;
            //if (_DataGridViewX.Width + _X > _parentW)
            //    _DataGridViewX.Left = _X - (_DataGridViewX.Width - this.Width);

            //int Y = this.Height;
            //int xx = this.TopLevelControl.Top;
            //int yy = this.TopLevelControl.Left;
            //int xxHeight = this.TopLevelControl.Height;
            //int xxWidth = this.TopLevelControl.Width;
            //int thisHeight = _DataGridViewX.Height;
            if (_DataGridViewX.Height + _x.Y + this.Height + 2 > this.TopLevelControl.Height)
                _DataGridViewX.Location = new Point(_x.X - this.TopLevelControl.Margin.Left - this.Margin.Left, _x.Y - _DataGridViewX.Height + this.Margin.Top);
                //_DataGridViewX.Top = this.Location.Y - _DataGridViewX.Height;
           // else if (this.Parent is Form)
                
            //    _DataGridViewX.Top = this.Location.Y + this.Height;
            //_DataGridViewX.Left = this.Location.X;
            else
                _DataGridViewX.Location = new Point(_x.X - this.TopLevelControl.Margin.Left - this.Margin.Left, _x.Y + this.Height);              
        }

        private void _DataGridViewX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _strText;
            _strText = _DataGridViewX.CurrentRow.Cells[_ColumnNames[0]].Value.ToString();
            this.Text = _strText;            
            _DataGridViewX.Visible = false;
        }
        private void _AutoNumberForGrid(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                
                for (int i = 0; i < dataGridView.Rows.Count ; i++)
                {
                    dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    
                }
            }
        }
        private void _DataGridViewX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_DataGridViewX.Focused == false)
                    return;
                string _strProductID;
                _strProductID = _DataGridViewX.CurrentRow.Cells[_ColumnNames[0]].Value.ToString();
                this.Text = _strProductID;
                _DataGridViewX.Visible = false;
                this.Parent.Focus(); 
            }
            if (e.KeyCode == Keys.Escape)
            {
                _DataGridViewX.Visible = false;
                this.Parent.Focus(); 
            }
            
        }
        private void _DataGridViewX_Leave(object sender, EventArgs e)
        {
            if (_DataGridViewX.Visible == true)
            {
                _DataGridViewX.Visible = false;
            }
        }

        private int _getItemRow(String _strString)
        {
            int _intRow = 0;
            for (int i = 0; i < _DataGridViewX.RowCount; i++)
            {
                string _strID = _DataGridViewX.Rows[i].Cells[_ColumnNames[0]].Value.ToString();
                if (_strString.IndexOf(_strID) == 0)
                {
                    return i;                    
                }
            }
            return _intRow;
        }
        // Thay doi cac kich thuoc cua column, Grid        
       
        public DataTable DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }
        public bool AutoComplete
        {
            get
            {
                return _AutoComplete;
            }
            set
            {
                _AutoComplete = value;
            }
        }
        public bool AutoReSizeColumn
        {
            get
            {
                return _AutoResizeColumn;
            }
            set
            {
                _AutoResizeColumn = value;
            }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public int RowsDisplay
        {
            get { return _RowsDisPlay; }
            set { _RowsDisPlay = value; }
        }
        public bool AutoDropdown
        {
            get
            {
                return _AutoDropdown;
            }
            set
            {
                _AutoDropdown = value;
            }
        }
        public Color BackColorEven
        {
            get
            {
                return _BackColorEven;
            }
            set
            {
                _BackColorEven = value;
            }
        }
        public Color BackColorOdd
        {
            get
            {
                return _BackColorOdd;
            }
            set
            {
                _BackColorOdd = value;
            }
        }
        public Collection<string> ColumnNameCollection
        {
            get
            {
                return _ColumnNames;
            }
        }
        public string ColumnNames
        {
            get
            {
                return _ColumnNameStrings;
            }

            set
            {
                // If the column string is blank, leave it blank.
                // The default width will be used for all columns.
                if (!Convert.ToBoolean(value.Trim().Length))
                {
                    _ColumnNameStrings = "";
                }
                else if (value != null)
                {
                    char[] delimiterChars = { ',', ';', ':' };
                    string[] columnNames = value.Split(delimiterChars);

                    if (!DesignMode)
                    {
                        _ColumnNames.Clear();
                    }

                    // After splitting the string into an array, iterate
                    // through the strings and check that they're all valid.
                    foreach (string s in columnNames)
                    {
                        // Does it have length?
                        if (Convert.ToBoolean(s.Trim().Length))
                        {
                            if (!DesignMode)
                            {
                                _ColumnNames.Add(s.Trim());
                            }
                        }
                        else // The value is blank
                        {
                            throw new NotSupportedException("Column names can not be blank.");
                        }
                    }
                    _ColumnNameStrings = value;
                }
                
            }
        }
        public string ColumnHeaders
        {
            get
            {
                return _ColumnHeaderStrings ;
            }

            set
            {
                // If the column string is blank, leave it blank.
                // The default width will be used for all columns.
                if (!Convert.ToBoolean(value.Trim().Length))
                {
                    _ColumnHeaderStrings = "";
                }
                else if (value != null)
                {
                    char[] delimiterChars = { ',', ';', ':' };
                    string[] ColumnHeaders = value.Split(delimiterChars);

                    if (!DesignMode)
                    {
                        _ColumnHeaders.Clear();
                    }

                    // After splitting the string into an array, iterate
                    // through the strings and check that they're all valid.
                    foreach (string s in ColumnHeaders)
                    {
                        // Does it have length?
                        if (Convert.ToBoolean(s.Trim().Length))
                        {
                            if (!DesignMode)
                            {
                                _ColumnHeaders.Add(s.Trim());
                            }
                        }
                        else // The value is blank
                        {
                            throw new NotSupportedException("Column headers can not be blank.");
                        }
                    }
                    _ColumnHeaderStrings = value;
                }
                else
                {
                    //Neu khong truyen vao 

                }
            }
        }
        public string ColumnWidths
        {
            get
            {
                return _ColumnWidthStrings;
            }

            set
            {
                // If the column string is blank, leave it blank.
                // The default width will be used for all columns.
                if (!Convert.ToBoolean(value.Trim().Length))
                {
                    _ColumnWidthStrings = "";
                }
                else if (value != null)
                {
                    char[] delimiterChars = { ',', ';', ':' };
                    string[] ColumnWidths = value.Split(delimiterChars);

                    if (!DesignMode)
                    {
                        _ColumnWidths.Clear();
                    }

                    // After splitting the string into an array, iterate
                    // through the strings and check that they're all valid.
                    foreach (string s in ColumnWidths)
                    {
                        // Does it have length?
                        if (Convert.ToBoolean(s.Trim().Length))
                        {
                            if (!DesignMode)
                            {
                                _ColumnWidths.Add(Convert.ToInt32(s.Trim()));
                            }
                        }
                        else // The value is blank
                        {
                            throw new NotSupportedException("Column headers can not be blank.");
                        }
                    }
                    _ColumnWidthStrings = value;
                }
                //else
                //    _ColumnWidths = null;
            }
        }
        public Collection<int> ColumnWidthCollection
        {
            get
            {
                return _ColumnWidths;
            }
        }
        public int ColumnWidthDefault
        {
            get
            {
                return _ColumnWidthDefault;
            }
            set
            {
                _ColumnWidthDefault = value;
            }
        }
        public int LinkedColumnIndex
        {
            get
            {
                return _LinkedColumnIndex;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A column index can not be negative");
                }
                _LinkedColumnIndex = value;
            }
        }
        public TextBox LinkedTextBox
        {
            get
            {
                return _LinkedTextBox;
            }
            set
            {
                _LinkedTextBox = value;

                if (_LinkedTextBox != null)
                {
                    // Set any default properties of the Linked Textbox here
                    _LinkedTextBox.ReadOnly = true;
                    _LinkedTextBox.TabStop = false;
                }
            }
        }
        public int TotalWidth
        {
            get
            {
                return _TotalWidth;
            }
        }

    }
}
