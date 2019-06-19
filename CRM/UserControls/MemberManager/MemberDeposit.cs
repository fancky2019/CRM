using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CRM.Model.EntityModels;
using CRM.BLL.ProductManager;
using CRM.Model.QueryModels;

namespace CRM.UserControls.MemberManager
{
    /// <summary>
    /// 充值
    /// </summary>
    public partial class MemberDeposit : XtraUserControl
    {
        MemberManagerBll _memberManagerBll = null;
        public MemberDeposit()
        {
            InitializeComponent();
            _memberManagerBll = new MemberManagerBll();
        }

        private void SbtnDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tePhoneNumber.Text.Trim()))
            {
                XtraMessageBox.Show("会员手机号不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(this.teDepositAmount.Text.Trim()))
            {
                XtraMessageBox.Show("充值金额不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(this.tePayAmount.Text.Trim()))
            {
                XtraMessageBox.Show("实收金额不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }

            var member = _memberManagerBll.GetMemberByPhoneNumber(this.tePhoneNumber.Text.Trim());
            if(member == null)
            {
                XtraMessageBox.Show($"不存在手机号为{this.tePhoneNumber.Text.Trim()}的会员！", "提示", MessageBoxButtons.OK);
                return;
            }
            splashScreenManager.ShowWaitForm();
            splashScreenManager.SetWaitFormCaption("提示");
            splashScreenManager.SetWaitFormDescription("充值中...");
            Deposit deposit = new Deposit()
            {
                MemberID = member.ID,
                DepositAmount = decimal.Parse(this.teDepositAmount.Text.Trim()),
                PayAmount = decimal.Parse(this.tePayAmount.Text),
                CreateTime = DateTime.Now,
                Remark = this.meRemark.Text.Trim()
            };
            int result = _memberManagerBll.MemberDeposit(deposit);
            splashScreenManager.CloseWaitForm();
            if (result > 0)
            {
                XtraMessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("充值失败！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
