﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// A sample User entity class
/// </summary>
public class WebUser
{
    public WebUser()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string UniqueId
    {
        get;
        set;
    }
    public string Token
    {
        get;
        set;
    }

    public string UserName
    {
        get;
        set;
    }

    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }
}
