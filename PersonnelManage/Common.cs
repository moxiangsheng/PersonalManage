using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PersonnelManage
{
    public enum LoginType
    { 
        Admin=0,//管理员
        Student=1//学生
    }
    public enum optAED
    { 
        Add=1,
        Edit=0,
        Detail=2
    }
    class Common
    {
        public static string APTION ="提示";
        public static int EpId;//当前用户员工Id
        public static int SendEpId;
        public static string Message="用户名或密码不正确！";
        public static string UserName;//当前用户名
        public static string UserPwd;//当前密码
        public static string EpName;//
        public static sqlHelper helper = new sqlHelper();

        #region 方法：正则表达式判读字符串是否为11位数字
        public static bool IsFloat(string str)
        {
            string regextext = @"^\d{11}$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str.Trim());
        } 
        #endregion

        #region 动态绑定部门
        public static void BindDept(ComboBox cmbDepart)
        {
            string sSql = "select DeptId,DeptName from Depart ";
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql, "Depart");
            DataRow row = ds.Tables["Depart"].NewRow();
            row[0] = 0;
            row[1] = "所有部门";
            ds.Tables["Depart"].Rows.InsertAt(row, 0);
            DataRow row1 = ds.Tables["Depart"].NewRow();
            row1[0] = -1;
            row1[1] = "请选择";
            ds.Tables["Depart"].Rows.InsertAt(row1, 0);
            cmbDepart.DisplayMember = "DeptName";
            cmbDepart.ValueMember = "DeptId";
            cmbDepart.DataSource = ds.Tables["Depart"];
        }
        #endregion

        #region 动态绑定职位(通过部门查询职位)
        public static void BindPosition(ComboBox cmbPos,int DeptId)
        {
            string sSql = "select pId,positionName from Position ";
            if (DeptId != 0)
            {
                sSql = sSql + " where DeptId=" + DeptId;
            }

            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(sSql, helper.connectionStr, "position");
           if(DeptId==0){
                DataRow row = ds.Tables["position"].NewRow();
                row[0] = 0;
                row[1] = "所有职位";
                ds.Tables["position"].Rows.InsertAt(row, 0);
               }
            DataRow row1 = ds.Tables["position"].NewRow();
            row1[0] = -1;
            row1[1] = "请选择";
            ds.Tables["position"].Rows.InsertAt(row1, 0);
            cmbPos.DisplayMember = "positionName";
            cmbPos.ValueMember = "pId";
            cmbPos.DataSource = ds.Tables["position"];
        }
        #endregion

        #region 动态绑定部门(查询所有部门)
        public static void BindAllDepart(ComboBox cmbDepart)
        {
            string sSql = "select DeptId,DeptName from Depart ";
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql, "Depart");
            DataRow row = ds.Tables["Depart"].NewRow();
            row[0] = 0;
            row[1] = "请选择";
            ds.Tables["Depart"].Rows.InsertAt(row, 0);
            cmbDepart.DisplayMember = "DeptName";
            cmbDepart.ValueMember = "DeptId";
            cmbDepart.DataSource = ds.Tables["Depart"];
        }
        #endregion

        #region 动态绑定职位（查询对应部门的全部职位）
        public static void BindAllPosition(ComboBox cmbPosition,int DeptId)
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append( "select pId,positionName from Position ");
            sSql.AppendFormat(" where DeptId={0}",DeptId);
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr,sSql.ToString(),"position");
            DataRow row = ds.Tables["position"].NewRow();
            row[0] = 0;
            row[1] = "请选择";
            ds.Tables["position"].Rows.InsertAt(row, 0);
            cmbPosition.DisplayMember = "positionName";
            cmbPosition.ValueMember = "pId";
            cmbPosition.DataSource = ds.Tables["position"];
        }
        #endregion

        #region 按员工号查询员工姓名
        public static string GetEmploryeeNameByEpId(int EpId )
        {
            string EmploryeeName = null;
            string sSql = "select EpName from Emploryee where EpId= " + EpId;
            sqlHelper helper = new sqlHelper();
            SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql);
            if (dr.Read())
            {
                EmploryeeName = dr["EpName"].ToString().Trim();
            }
            return EmploryeeName;
        } 
        #endregion
    }
}
