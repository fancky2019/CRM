using CRM.BLL.ProductManager;
using CRM.Model.EntityModels;
using CRM.Model.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace CRM.UserControls.ProcuctManager
{
    public partial class MemberEdit : EditUserControl
    {

        MemberManagerBll _memberManagerBll = null;

        public MemberEdit()
        {
            InitializeComponent();

            _memberManagerBll = new MemberManagerBll();


        }
        private void ProductEdit_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                MemberVM member = this.Tag as MemberVM;
                this.teUserName.Text = member.UserName;
                this.tePassword.Text = member.Password;
                this.tePhoneNumber.Text = member.PhoneNumber;
                this.teIDCard.Text = member.IDCard;
                this.teAddress.Text = member.Address;
                this.meRemark.Text = member.Remark;
            }
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teUserName.Text.Trim()))
            {
                XtraMessageBox.Show("名称不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }
   
            if (string.IsNullOrEmpty(tePhoneNumber.Text.Trim()))
            {
                XtraMessageBox.Show("手机号不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }
            Member member = new Member()
            {
                UserName = this.teUserName.Text.Trim(),
                Password = this.tePassword.Text.Trim(),
                PhoneNumber =this.tePhoneNumber.Text.Trim(),
                IDCard=this.teIDCard.Text.Trim(),
                Address=this.teAddress.Text.Trim(),
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                Remark = this.meRemark.Text.Trim(),
                Status=1
            };
            int result = 0;
            if (this.Tag != null)//编辑
            {
                var oldMember = this.Tag as MemberVM;
                member.ID = oldMember.ID;
                member.CreateTime = oldMember.CreateTime;
                member.ModifyTime = DateTime.Now;
                result = _memberManagerBll.Update(member);
            }
            else//新增
            {
                if (_memberManagerBll.Exist(member))
                {
                    XtraMessageBox.Show("该手机号已注册！", "提示", MessageBoxButtons.OK);
                    return;
                }
                result = _memberManagerBll.Add(member);
            }
            if (result > 0)
            {
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
