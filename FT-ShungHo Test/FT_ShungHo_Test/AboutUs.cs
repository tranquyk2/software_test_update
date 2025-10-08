using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x02000003 RID: 3
	internal partial class AboutUs : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		public AboutUs()
		{
			this.InitializeComponent();
			this.Text = string.Format("About {0}", this.AssemblyTitle);
			this.labelProductName.Text = this.AssemblyProduct;
			this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
			this.labelCopyright.Text = this.AssemblyCopyright;
			this.labelCompanyName.Text = this.AssemblyCompany;
			this.textBoxDescription.Text = this.AssemblyDescription;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		public string AssemblyTitle
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				bool flag = customAttributes.Length != 0;
				if (flag)
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
					bool flag2 = assemblyTitleAttribute.Title != "";
					if (flag2)
					{
						return assemblyTitleAttribute.Title;
					}
				}
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002158 File Offset: 0x00000358
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002180 File Offset: 0x00000380
		public string AssemblyDescription
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
				}
				return result;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021C8 File Offset: 0x000003C8
		public string AssemblyProduct
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyProductAttribute)customAttributes[0]).Product;
				}
				return result;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002210 File Offset: 0x00000410
		public string AssemblyCopyright
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
				}
				return result;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002258 File Offset: 0x00000458
		public string AssemblyCompany
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "Tin Phat Mechanic - Automation Company";
				}
				else
				{
					result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
				}
				return result;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000229F File Offset: 0x0000049F
		private void About_Load(object sender, EventArgs e)
		{
			this.labelCompanyName.Text = "Company name : Tin Phat Mechanic - Automation Company";
			this.textBoxDescription.Text = "Description : 0987541862 \n\t\t\t Email: sales@cokhitinphat.com";
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022C4 File Offset: 0x000004C4
		private void okButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
