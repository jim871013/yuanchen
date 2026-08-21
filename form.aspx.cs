using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string outstr = "表單輸入完成：<br />";
        string Name = Request.QueryString["Sname"].ToString();
        string Company = Request.QueryString["Scompany"].ToString();
        string Email = Request.QueryString["Semail"].ToString();
        string Phone = Request.QueryString["Sphone"].ToString();
        string Text = Request.QueryString["Stext"].ToString();

        outstr += "公司名稱：" + Company + "<br />聯絡人：" + Name + "<br />電子信箱：" + Email + "<br />手機號碼：" + Phone + "<br />詢問內容：<br />" + Text ;

        Label1.Text = outstr ;
    }
}