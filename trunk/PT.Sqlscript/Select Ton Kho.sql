select Rlsed, * from INDOc

select Rlsed, WhID,ToWhID, LineQty,INUnit,UnitRate,Cnvfact,DetailQty,InvtMult, * from INDocDet

-- Ton Dau
select WhID,LotID,ProductID,SUM(InvtMult*DetailQty) from INDocDet
where Rlsed = -1
and TranDate <= GETDATE()
group by WhID,LotID,ProductID

-- Nhap mua
select WhID,LotID,ProductID,SUM(InvtMult*DetailQty) from INDocDet
where Rlsed = -1
and TranDate between GETDATE() and GETDATE() and TranType IN('MH','NT') and InvtMult = 1
group by WhID,LotID,ProductID

-- Nhap DC
select WhID,LotID,ProductID,SUM(InvtMult*DetailQty) from INDocDet
where Rlsed = -1
and TranDate between GETDATE() and GETDATE() and TranType in( 'DC','CK')
and InvtMult = 1
group by WhID,LotID,ProductID


