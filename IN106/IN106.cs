using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.DataInfo;
using PT.Helper;
using PT.MainCtl;


namespace IN106
{
    public partial class IN106 : PT.Master.GridEdit
    {
        private byte _strStage = 0; // 1 la chinh sua, 2 la them moi, 0 ko lam gi
        private DataTable _dtINProduct = new DataTable();
        private DataTable _dtINProductClass1 = new DataTable();
        private DataTable _dtINProductClass2 = new DataTable();
        private DataTable _dtINUnit = new DataTable();
        private DataTable _dtSITax = new DataTable();
        private DataTable _dtAPVendor = new DataTable();
        private DataTable _dtINWarehouse = new DataTable();
        public IN106()
        {
            InitializeComponent();
        }
        private void IN106_Load(object sender, EventArgs e)
        {           
            strPro = "IN106";
            _BindGrid();
            _strStage = 2;
            _ChangeControlName();            
        }   
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           INProduct _info = new INProduct();
           _info = _GetProduct(e.RowIndex);
           _BindDataToPanel();
           _AddToPanel(_info);           
           _strStage = 1;
           txtCopy.Enabled = false;
           btnCopy.Enabled = false;
            
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _RefreshPanel();
            txtProductID.Enabled = true;
            txtProductID.Focus();
            _BindDataToPanel();
            _strStage = 1;
            btnCopy.Enabled = true;
            txtCopy.Enabled = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (pnl.Visible == true)
            {
                string proid = txtProductID.Text.Trim();
                INProduct _product = _GetProduct(proid);
                if (_product != null)
                {
                    _RefreshPanel();
                    _AddToPanel(_product);
                }
                else
                {
                    _RefreshPanel();
                    txtProductID.Enabled = true;
                    txtProductID.Focus();
                }
            }
            else if (dgv.Visible == true)
                _BindGrid();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.Visible == true)
            {
                Int32 _intTotalRow = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (_intTotalRow > 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa '" + _intTotalRow + 
                                        "' dòng được chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < _intTotalRow; i++)
                        {
                            int _row = Int16.Parse(dgv.SelectedRows[i].Index.ToString());
                            _DeleteRow(_row);
                        }
                        _BindGrid();
                    }

                }
            }
            else if(pnl.Visible == true )
            {
                string _strProductID = txtProductID.Text.Trim();

                if (IN106Ctrl.CheckProductUsed(_strProductID) == false)
                {
                    int _row1 = _GetProductRow(_strProductID);
                    if (_row1 == -1)
                        return;
                    if (MessageBox.Show("Mã sản phẩm: '" + _strProductID +
                                        "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int _row = _GetProductRow(_strProductID);
                        INProduct _INProduct = new INProduct();
                        _INProduct = _GetProduct(_row + 1);
                        _DeleteRow(_strProductID);
                        _BindGrid();
                        _RefreshPanel();
                        _AddToPanel(_INProduct);

                    }
                }
                else
                    MessageBox.Show("Mã sản phẩm: " + _strProductID +
                                    " đang được dùng, bạn không thể xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckNotNull() == true)
            {
                if (_strStage == 2)
                {
                    if (_CheckValid() == true)
                    {
                        INProduct info = _GetPanel();
                        IN106Ctrl.SaveProduct(info);
                    }
                }
                else if (_strStage == 1)
                {
                    INProduct info = _GetPanel();
                    IN106Ctrl.SaveProduct(info);
                }
                txtProductID.Enabled = false;
                txtDesc.Focus();
                btnCopy.Enabled = false;
                txtCopy.Enabled = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _strStage = 2;
        }        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string copy = txtCopy.Text.Trim();
            string proid = txtProductID.Text.Trim();
            if (copy == "")
            {
                Utility.MessageShow("001", Globals.PTLanguage,"ProductID");
                txtCopy.Focus();
                return;
            }
            if (_dtINProduct.Rows.Count > 0)
            {
                DataRow[] dr = _dtINProduct.Select(string.Format("ProductID = '{0}'", copy));
                if (dr.Count() <= 0)
                {
                    MessageBox.Show("ProductID khong ton tai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCopy.Focus();
                    txtCopy.SelectionStart = 0;
                    txtCopy.SelectionLength = copy.Length;                    
                    return;
                }
                else
                {
                    INProduct p = new INProduct();
                    p = _GetProduct(copy);
                    _AddToPanel(p);
                    _BindDataToPanel();
                    dgv.Visible = false;
                    pnl.Visible = true;
                    txtProductID.Enabled = true;
                    txtProductID.Text = copy + "-1";
                    txtProductID.Focus();
                    txtProductID.SelectionStart = 0;
                    txtProductID.SelectionLength = txtProductID.Text.Length; ;
                }
            }
        }
        private void txtCopy_GotFocus(object sender, EventArgs e)
        {
            txtCopy.Text = "";
        }
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text.ToUpper();
            txtProductID.SelectionStart = txtProductID.Text.Length;
            txtProductID.SelectionLength = txtProductID.Text.Length;
        }
        private void txtClassID1_TextChanged(object sender, EventArgs e)
        {
            string text = txtClassID1.Text.Trim();
            if (text != "")
            {
                INProductClass1 class1 = new INProductClass1();
                class1 = _GetClass1Info(text);
                if (class1 != null)
                {
                    _SetClass1ToPanel(class1);
                }

            }
        }
        private void txtClassID2_TextChanged(object sender, EventArgs e)
        {
            string text = txtClassID2.Text.Trim();
            if (text != "")
            {
                INProductClass2 class2 = new INProductClass2();
                class2 = _GetClass2Info(text);
                if (class2 != null)
                    _SetClass2ToPanel(class2);
            }
        }
        //private void txtProductID_Leave(object sender, EventArgs e)
        //{
        //    if (txtProductID.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtProductID.Focus();
        //    }

        //}
        //private void txtDesc_Leave(object sender, EventArgs e)
        //{
        //    if (txtDesc.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtDesc.Focus();
        //    }
        //}
        //private void txtClassID2_Leave(object sender, EventArgs e)
        //{
        //    if (txtClassID2.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtClassID2.Focus();
        //    }
        //}
        //private void txtVendID_Leave(object sender, EventArgs e)
        //{
        //    if (txtVendID.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtVendID.Focus();
        //    }
        //}
        //private void cbxStatus_Leave(object sender, EventArgs e)
        //{
        //    if (cbxStatus.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        cbxStatus.Focus();
        //    }
        //}
        //private void txtCnvfact_Leave(object sender, EventArgs e)
        //{
        //    if (txtCnvfact.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtCnvfact.Focus();
        //    }
        //}
        //private void txtFromUnit_Leave(object sender, EventArgs e)
        //{
        //    if (txtFromUnit.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtFromUnit.Focus();
        //    }
        //}
        //private void txtToUnit_Leave(object sender, EventArgs e)
        //{
        //    if (txtToUnit.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtToUnit.Focus();
        //    }
        //}
        //private void txtPOUnit_Leave(object sender, EventArgs e)
        //{
        //    if (txtPOUnit.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtPOUnit.Focus();
        //    }
        //}
        //private void txtSOUnit_Leave(object sender, EventArgs e)
        //{
        //    if (txtSOUnit.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtSOUnit.Focus();
        //    }
        //}
        //private void txtDfltWhID_Leave(object sender, EventArgs e)
        //{
        //    if (txtDfltWhID.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtDfltWhID.Focus();
        //    }
        //}
        //private void txtTaxID_Leave(object sender, EventArgs e)
        //{
        //    if (txtTaxID.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Khong duoc rong", "thong bao");
        //        txtTaxID.Focus();
        //    }
        //}


        private void _BindGrid()
        {
            //DataTable _dtINProduct = new DataTable();
            dgv.Visible = false;
            _dtINProduct = IN106Ctrl.GetAllProduct();
            dgv.DataSource = _dtINProduct;
            _RefreshPanel();
            dgv.Refresh();
            dgv.Visible = true;
            if (dgv.Rows.Count > 0)
                btnCopy.Enabled = true;
            else
                btnCopy.Enabled = false;
        }
        private void _BindDataToPanel()
        {
            _dtINProductClass1 = IN106Ctrl.GetINProductClass1();
            _dtINProductClass2 = IN106Ctrl.GetINProductClass2();
            _dtINUnit = IN106Ctrl.GetINUnit();
            _dtSITax = IN106Ctrl.GetTax();
            _dtAPVendor = IN106Ctrl.GetAPVendor();
            _dtINWarehouse = IN106Ctrl.GetINWarehouse();

            string[] selectedColumns1 = new[] { "ClassID1", "Descr"};
            DataTable dtINProductClass1SelectedColumns =
                new DataView(_dtINProductClass1).ToTable(false, selectedColumns1);

            string[] selectedColumns2 = new[] { "ClassID2","Descr"};
            DataTable dtINProductClass2SelectedColumns =
               new DataView(_dtINProductClass2).ToTable(false, selectedColumns2);

            string[] selectedColumsUnit = new[] { "Unit" };
            DataTable dtselectedColumsUnit =
               new DataView(_dtINUnit).ToTable(false, selectedColumsUnit);
            DataTable dtselectedColumsUnit2 =
               new DataView(_dtINUnit).ToTable(false, selectedColumsUnit);
            DataTable dtselectedColumsUnit3 =
               new DataView(_dtINUnit).ToTable(false, selectedColumsUnit);
            DataTable dtselectedColumsUnit4 =
               new DataView(_dtINUnit).ToTable(false, selectedColumsUnit);
            DataTable dtselectedColumsUnit5 =
               new DataView(_dtINUnit).ToTable(false, selectedColumsUnit);
            

            string[] selectedColumsProduct = new[] { "ProductID","Descr" };
            DataTable dtselectedColumsProduct =
               new DataView(_dtINProduct).ToTable(false, selectedColumsProduct);

            string[] selectedColumsVendID = new[] { "VendID", "VendName" };
            DataTable dtselectedColumsVendID =
               new DataView(_dtAPVendor).ToTable(false, selectedColumsVendID);

            string[] selectedColumsTaxID = new[] { "TaxID", "Descr" };
            DataTable dtselectedColumsTaxID =
               new DataView(_dtSITax).ToTable(false, selectedColumsTaxID);

            string[] selectedColumsWarehouse = new[] { "WhId", "Name" };
            DataTable dtselectedColumsWarehouse =
               new DataView(_dtINWarehouse).ToTable(false, selectedColumsWarehouse);


            txtClassID1.DataSource = dtINProductClass1SelectedColumns;
            txtClassID2.DataSource = dtINProductClass2SelectedColumns;

            txtFromUnit.DataSource = dtselectedColumsUnit;
            txtFromUnit.DisplayMember = "Unit";
            txtFromUnit.ValueMember = "Unit";
            txtFromUnit.ColumnWidths = "150,150";
            txtFromUnit.AutoComplete = true;
            txtFromUnit.LinkedColumnIndex = 1;

            txtToUnit.DataSource = dtselectedColumsUnit2;
            txtToUnit.DisplayMember = "Unit";
            txtToUnit.ValueMember = "Unit";
            txtToUnit.ColumnWidths = "150,150";
            txtToUnit.AutoComplete = true;
            //txtToUnit.LinkedColumnIndex = 1;

            txtCopy.DataSource = dtselectedColumsProduct;

            txtPOUnit.DataSource = dtselectedColumsUnit3;
            txtPOUnit.DisplayMember = "Unit";
            txtPOUnit.ValueMember = "Unit";
            txtPOUnit.ColumnWidths = "150,150";
            txtPOUnit.AutoComplete = true;
            //txtPOUnit.LinkedColumnIndex = 1;

            txtSOUnit.DataSource = dtselectedColumsUnit4;
            txtSOUnit.DisplayMember = "Unit";
            txtSOUnit.ValueMember = "Unit";
            txtSOUnit.ColumnWidths = "150,150";
            txtSOUnit.AutoComplete = true;
            //txtSOUnit.LinkedColumnIndex = 1;

            txtINUnit.DataSource = dtselectedColumsUnit5;
            txtINUnit.DisplayMember = "Unit";
            txtINUnit.ValueMember = "Unit";
            txtINUnit.ColumnWidths = "150,150";
            txtINUnit.AutoComplete = true;
            //txtINUnit.LinkedColumnIndex = 1;

            txtVendID.DataSource = dtselectedColumsVendID;
            txtVendID.DisplayMember = "VendName";
            txtVendID.ValueMember = "VendID";
            txtVendID.ColumnWidths = "150,150";
            txtVendID.AutoComplete = true;
            txtVendID.LinkedColumnIndex = 1;

            txtTaxID.DataSource = dtselectedColumsTaxID;
            txtTaxID.ColumnNames = "Descr,TaxId";
            txtTaxID.DisplayMember = "Descr";
            txtTaxID.ValueMember = "TaxID";
            txtTaxID.ColumnWidths = "150,150";
            txtTaxID.AutoComplete = true;
            txtTaxID.SelectedText = "Descr";

            txtDfltWhID.DataSource = dtselectedColumsWarehouse;
            txtDfltWhID.ColumnNames = "Name,WhId";
            txtDfltWhID.DisplayMember = "Name";
            txtDfltWhID.ValueMember = "WhId";
            txtDfltWhID.SelectedItem = "WhID";
            txtDfltWhID.ColumnWidths = "150,150";
            txtDfltWhID.AutoComplete = true;
            txtDfltWhID.LinkedColumnIndex = 1;

            txtProductID.Focus();
            
        }
        private INProductClass1 _GetClass1Info(string classid)
        {
            INProductClass1 productclass1 = new INProductClass1();
            DataRow[] dr = _dtINProductClass1.Select("ClassID1 = '" + classid + "'");
            if (dr.Count() > 0)
                productclass1 = IN106Ctrl.Class1toInfo(dr[0]);
            else
                productclass1 = null;
            return productclass1;
        }
        private INProductClass2 _GetClass2Info(string classid)
        {
            INProductClass2 productclass2 = new INProductClass2();
            DataRow[] dr = _dtINProductClass2.Select("ClassID2 = '" + classid + "'");
            if (dr.Count() > 0)
                productclass2 = IN106Ctrl.Class2toInfo(dr[0]);
            else
                productclass2 = null;
            return productclass2;
        }
        private void _SetClass1ToPanel(INProductClass1 info)
        {
            txtDfltWhID.Text = info.DfltWhID;
            txtTaxID.Text = info.DfltTaxID;
            txtPOUnit.Text = info.POUnit;
            txtSOUnit.Text = info.SOUnit;
            txtVendID.Text = info.VendID;
        }
        private void _SetClass2ToPanel(INProductClass2 info)
        {
            txtDfltWhID.Text = info.DfltWhID;
            txtTaxID.Text = info.DfltTaxID;
            txtPOUnit.Text = info.POUnit;
            txtSOUnit.Text = info.SOUnit;
            txtVendID.Text = info.VendID;
            txtClassID1.Text = info.ClassID1;
        }
        private void _AddToPanel(INProduct _info)
        {
            if (_info != null)
            {
                txtProductID.Text = _info.ProductID.ToString();
                txtDesc.Text = _info.Descr.ToString();
                txtClassID1.Text = _info.ClassID1.ToString();
                txtClassID2.Text = _info.ClassID2.ToString();
                txtVendID.SelectedValue = _info.VendID.ToString();
                cbxStatus.Text = _info.Status.ToString();
                txtFromUnit.SelectedValue = _info.FromUnit.ToString();
                txtToUnit.SelectedValue = _info.ToUnit.ToString();
                txtCnvfact.Text = _info.Cnvfact.ToString();
                txtPOFromUnitPrice.Text = _info.POFromUnitPrice.ToString();
                txtPOToUnitPrice.Text = _info.POToUnitPrice.ToString();
                if (_info.POPriEffDate.ToString() != "")
                    dtiPOPriEffDate.Value = _info.POPriEffDate;
                txtSOFromUnitPrice.Text = _info.SOFromUnitPrice.ToString();
                txtSOToUnitPrice.Text = _info.SOToUnitPrice.ToString();
                if (_info.SOPriEffDate.ToString() != "")
                    dtiSOPriEffDate.Value = _info.SOPriEffDate;
                txtPOUnit.SelectedValue = _info.POUnit.ToString();
                txtSOUnit.SelectedValue = _info.SOUnit.ToString();
                txtINUnit.SelectedValue = _info.INUnit.ToString();
                txtColor.Text = _info.Color.ToString();
                txtDfltWhID.SelectedValue = _info.DfltWhID.ToString();
                txtPicture.Text = _info.Picture.ToString();
                txtSize.Text = _info.Size.ToString();
                txtVolume.Text = _info.Volume.ToString();
                txtWeight.Text = _info.Weight.ToString();
                txtStyle.Text = _info.Style.ToString();
                txtTaxID.SelectedValue = _info.TaxID.ToString();
                txtProductID.Text = _info.ProductID;
                txtProductID.Enabled = false;
                if (_info.Crtd_DateTime.ToString() == "")
                    dtiCrtd_DateTime.Value = DateTime.Now;
                else
                    dtiCrtd_DateTime.Value = _info.Crtd_DateTime;
                txtCrtd_Prog.Text = _info.Crtd_Prog.ToString();
                txtCrtd_User.Text = _info.Crtd_User.ToString();
            }
        }
        private void _RefreshPanel()
        {
            txtProductID.Text = "";
            txtDesc.Text = "";
            txtClassID1.Text = "";
            txtClassID2.Text = "";
            txtVendID.Text = "";
            cbxStatus.Text = "";
            txtFromUnit.Text = "";
            txtToUnit.Text = "";
            txtCnvfact.Text = "";
            txtPOFromUnitPrice.Text = "";
            txtPOToUnitPrice.Text = "";
            //dtiPOPriEffDate.Value = DateTime.Now;
            txtSOFromUnitPrice.Text = "";
            txtSOToUnitPrice.Text = "";
            //dtiSOPriEffDate.Value = DateTime.Now;
            txtPOUnit.Text = "";
            txtSOUnit.Text = "";
            txtINUnit.Text = "";
            txtColor.Text = "";
            txtDfltWhID.Text = "";
            txtPicture.Text = "";
            txtSize.Text = "";
            txtVolume.Text = "";
            txtWeight.Text = "";
            txtStyle.Text = "";
            txtTaxID.Text = "";
            txtProductID.Text = "";
            txtProductID.Enabled = false;
            txtProductID.Focus();
            //txtLUpd_User.Text = "";
            txtCrtd_Prog.Text = strPro;
            txtCrtd_User.Text = Globals.PTUserName;
            dtiCrtd_DateTime.Value = DateTime.Now;
        }
        private INProduct _GetPanel()
        {
            INProduct info = new INProduct();
            info.ProductID = txtProductID.Text.Trim();
            info.Descr = txtDesc.Text.Trim();
            info.ClassID1 = txtClassID1.Text.Trim();            
            info.ClassID2 = txtClassID2.Text.Trim();
            info.VendID = txtVendID.Text.Trim();
            info.Status = cbxStatus.Text.Trim();
            info.FromUnit = txtFromUnit.SelectedValue.ToString();
            info.ToUnit = txtToUnit.SelectedValue.ToString();
            if (txtCnvfact.Text.Trim() != "")
                info.Cnvfact = double.Parse(txtCnvfact.Text.Trim());
            if (txtPOFromUnitPrice.Text.Trim() != "")
                info.POFromUnitPrice = double.Parse(txtPOFromUnitPrice.Text.Trim());            
            if (txtPOToUnitPrice.Text.Trim() != "")
                info.POToUnitPrice =  double.Parse(txtPOToUnitPrice.Text.Trim());                
            if (txtSOFromUnitPrice.Text.Trim() != "")
                info.SOFromUnitPrice =  double.Parse(txtSOFromUnitPrice.Text.Trim());            
            if (txtSOToUnitPrice.Text.Trim() != "")
                info.SOToUnitPrice =  double.Parse(txtSOToUnitPrice.Text.Trim());
            info.POPriEffDate = dtiPOPriEffDate.Value;
            info.SOPriEffDate = dtiSOPriEffDate.Value;
            info.POUnit = txtPOUnit.SelectedValue.ToString();
            info.SOUnit = txtSOUnit.SelectedValue.ToString();
            info.INUnit = txtINUnit.SelectedValue.ToString();
            info.Color = txtColor.Text.Trim();
            info.DfltWhID = txtDfltWhID.SelectedValue.ToString();
            info.Picture = txtPicture.Text.Trim();
            info.Size = txtSize.Text.Trim();
            if (txtVolume.Text.Trim() != "")
                info.Volume =  double.Parse(txtVolume.Text.Trim());
            if (txtWeight.Text.Trim() != "")
                info.Weight = double.Parse(txtWeight.Text.Trim());
            info.Style = txtStyle.Text.Trim();
            info.TaxID = txtTaxID.SelectedValue.ToString();
            info.Crtd_DateTime = dtiCrtd_DateTime.Value;
            info.Crtd_Prog = txtCrtd_Prog.Text.Trim();
            info.Crtd_User = txtCrtd_User.Text.Trim();
            info.LUpd_DateTime = DateTime.Now;
            info.LUpd_Prog = strPro;
            info.LUpd_User = Globals.PTUserName;
            return info;
        }
        private void _DeleteRow(int row)
        {
            string _id = dgv.Rows[row].Cells["ProductID"].Value.ToString();
            if (IN106Ctrl.CheckProductUsed(_id) == true)
            {
                //MessageBox.Show("Sản phẩm này đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Utility.MessageShow("006",Globals.PTLanguage, "AG001");
                return;
            }
            IN106Ctrl.DeleteProduct(_id);
        }
        private void _DeleteRow(string productID)
        {
            if (IN106Ctrl.CheckProductUsed(productID) == true)
            {
                MessageBox.Show("Sản phẩm này đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IN106Ctrl.DeleteProduct(productID);
        }
        private INProduct _GetProduct(int _row)
        {
            INProduct _info = new INProduct();
            _info.ProductID = dgv.Rows[_row].Cells["ProductID"].Value.ToString().Trim();
            _info.Descr = dgv.Rows[_row].Cells["Descr"].Value.ToString();
            _info.ClassID1 = dgv.Rows[_row].Cells["ClassID1"].Value.ToString();
            _info.ClassID2 = dgv.Rows[_row].Cells["ClassID2"].Value.ToString();
            _info.VendID = dgv.Rows[_row].Cells["VendID"].Value.ToString();
            _info.Status = dgv.Rows[_row].Cells["Status"].Value.ToString();
            _info.FromUnit = dgv.Rows[_row].Cells["FromUnit"].Value.ToString();
            _info.ToUnit = dgv.Rows[_row].Cells["ToUnit"].Value.ToString();
            _info.Cnvfact = double.Parse(dgv.Rows[_row].Cells["Cnvfact"].Value.ToString());
            _info.POFromUnitPrice = double.Parse(dgv.Rows[_row].Cells["POFromUnitPrice"].Value.ToString());
            _info.POToUnitPrice = double.Parse(dgv.Rows[_row].Cells["POToUnitPrice"].Value.ToString());
            if (dgv.Rows[_row].Cells["POPriEffDate"].Value.ToString() != "")
                _info.POPriEffDate = DateTime.Parse(dgv.Rows[_row].Cells["POPriEffDate"].Value.ToString());
            if (dgv.Rows[_row].Cells["SOPriEffDate"].Value.ToString() != "")
                _info.SOPriEffDate = DateTime.Parse(dgv.Rows[_row].Cells["SOPriEffDate"].Value.ToString());
            _info.SOFromUnitPrice = double.Parse(dgv.Rows[_row].Cells["SOFromUnitPrice"].Value.ToString());
            _info.SOToUnitPrice = double.Parse(dgv.Rows[_row].Cells["SOToUnitPrice"].Value.ToString());
            _info.POUnit = dgv.Rows[_row].Cells["POUnit"].Value.ToString();
            _info.SOUnit = dgv.Rows[_row].Cells["SOUnit"].Value.ToString();
            _info.INUnit = dgv.Rows[_row].Cells["INUnit"].Value.ToString();
            _info.Color = dgv.Rows[_row].Cells["Color"].Value.ToString();
            _info.DfltWhID = dgv.Rows[_row].Cells["DfltWhID"].Value.ToString();
            _info.Picture = dgv.Rows[_row].Cells["Picture"].Value.ToString();
            _info.Size = dgv.Rows[_row].Cells["Size"].Value.ToString();
            _info.Volume = double.Parse(dgv.Rows[_row].Cells["Volume"].Value.ToString());
            _info.Weight = double.Parse(dgv.Rows[_row].Cells["Weight"].Value.ToString());
            _info.Style = dgv.Rows[_row].Cells["Style"].Value.ToString();
            _info.TaxID = dgv.Rows[_row].Cells["TaxID"].Value.ToString();
            _info.Crtd_DateTime = DateTime.Parse(dgv.Rows[_row].Cells["Crtd_DateTime"].Value.ToString());
            _info.Crtd_Prog = dgv.Rows[_row].Cells["Crtd_Prog"].Value.ToString(); ;
            _info.Crtd_User = dgv.Rows[_row].Cells["Crtd_User"].Value.ToString(); ;
            _info.LUpd_DateTime = DateTime.Parse(dgv.Rows[_row].Cells["LUpd_DateTime"].Value.ToString());
            _info.LUpd_Prog = dgv.Rows[_row].Cells["LUpd_Prog"].Value.ToString(); ;
            _info.LUpd_User = dgv.Rows[_row].Cells["LUpd_User"].Value.ToString(); ;

            return _info;
        }
        private INProduct _GetProduct(string _productID)
        {
            INProduct _info = new INProduct();
            DataRow[] _dr = null;
            _dr = _dtINProduct.Select(string.Format("ProductID = '{0}'", _productID));

            if (_dr.Length > 0)
                _info = IN106Ctrl.ConvertToInfo(_dr[0]);
            else
                _info = null;
            return _info;
        }
        private int _GetProductRow(string _productID)
        {
            int _row = -1;
            foreach (DataGridViewRow _dr in dgv.Rows)
            {
                if (_dr.Cells["ProductID"].Value.ToString().Trim().Equals(_productID))
                {
                    _row = _dr.Index;
                    break;
                }
            }

            return _row;
        }
        private bool _CheckValid()
        {
            string strProductID = txtProductID.Text.Trim();
            string strClassID1 = txtClassID1.Text.Trim();
            string strClassID2 = txtClassID2.Text.Trim();
            DateTime dtPOPriEffDate = dtiPOPriEffDate.Value;
            DateTime dtSOPriEffDate = dtiSOPriEffDate.Value;

            DataRow[] dr = _dtINProduct.Select(string.Format("ProductID = '{0}'", strProductID));
            if (dr.Count() > 0)
            {
                MessageBox.Show("ProductID đã được sử dụng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool _CheckNotNull()
        {
            INProduct info = _GetPanel();           
            if (info.ProductID == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtProductID.Focus();
                return false;
            }else if (info.Descr == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtDesc.Focus();
                return false;
            }else if (info.ClassID2== "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtClassID2.Focus();
                return false;
            }else if (info.VendID == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtVendID.Focus();
                return false;
            }else if (info.Status == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                cbxStatus.Focus();
                return false;
            }else if (info.Cnvfact.ToString() == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtCnvfact.Focus();
                return false;
            }else if (info.FromUnit == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtFromUnit.Focus();
                return false;
            }else if (info.ToUnit == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtToUnit.Focus();
                return false;
            }else if (info.POUnit == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtPOUnit.Focus();
                return false;
            }else if (info.SOUnit == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtSOUnit.Focus();
                return false;
            }else if (info.DfltWhID == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtDfltWhID.Focus();
                return false;
            }else if (info.TaxID == "")
            {
                MessageBox.Show("Khong duoc rong", "thong bao");
                txtTaxID.Focus();
                return false;
            }
            return true;
        }
        private void _ChangeControlName()
        {
            foreach (Control ctrl in pnl.Controls)
            {
                int textleng = ctrl.Name.Length;
                string label = ctrl.Name.Substring(0,3);
                string text = ctrl.Name.Substring(3,textleng - 3);
                if (label == "lbl")
                   ctrl.Text = Utility.ChangeLanguage(text,Globals.PTLanguage);
            }
        }
    }
}
