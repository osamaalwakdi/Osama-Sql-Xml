﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer for SQL Server tool using LINQ to SQL template.
// Code is generated on: 03/02/2024 03:47:57 ص
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace UserContext
{

    [System.Data.Linq.Mapping.DatabaseAttribute(Name = "Users")]
    public partial class UserDataContext : System.Data.Linq.DataContext
    {
        private static System.Data.Linq.Mapping.MappingSource mappingSource = new System.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();


        #endregion

        public UserDataContext() :
        base(GetConnectionString("UserDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public UserDataContext(System.Data.Linq.Mapping.MappingSource mappingSource) :
        base(GetConnectionString("UserDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName) 
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public UserDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public UserDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public UserDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public UserDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public System.Data.Linq.Table<Userstable> Userstables
        {
            get
            {
                return this.GetTable<Userstable>();
            }
        }

    
        /// <summary>
        /// There are no comments for OsaLogin in the schema.
        /// </summary>
        [Function(Name=@"dbo.Osa_Login")]
        [ResultType(typeof(OsaLoginResult))]
        [ResultType(typeof(OsaLoginResult1))]
        public System.Data.Linq.IMultipleResults OsaLogin([Parameter(Name="username", DbType="NVARCHAR(50)")] string username, [Parameter(Name="password", DbType="NVARCHAR(50)")] string password)
        {
            IExecuteResult _OsaLoginResult = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
            return ((System.Data.Linq.IMultipleResults)(_OsaLoginResult.ReturnValue));
        }

    
        /// <summary>
        /// There are no comments for OsaLoginuser in the schema.
        /// </summary>
        [Function(Name=@"dbo.Osa_Loginuser")]
        [ResultType(typeof(OsaLoginuserResult))]
        [ResultType(typeof(OsaLoginuserResult1))]
        public System.Data.Linq.IMultipleResults OsaLoginuser([Parameter(Name="username", DbType="NVARCHAR(50)")] string username, [Parameter(Name="password", DbType="NVARCHAR(50)")] string password)
        {
            IExecuteResult _OsaLoginuserResult = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
            return ((System.Data.Linq.IMultipleResults)(_OsaLoginuserResult.ReturnValue));
        }
    }


    /// <summary>
    /// There are no comments for OsaLoginResult in the schema.
    /// </summary>
    public partial class OsaLoginResult
    {
        private int _Column0;

        public OsaLoginResult()
        {
        }

    
        /// <summary>
        /// There are no comments for Column0 in the schema.
        /// </summary>
        [Column(Name = @"column0", Storage = "_Column0", DbType = "INT NOT NULL")]
        public int Column0
        {
            get
            {
                return this._Column0;
            }
            set
            {
                if (Object.Equals(this._Column0, value) == false)
                {
                    this._Column0 = value;
                }
            }
        }
      }

    /// <summary>
    /// There are no comments for OsaLoginResult1 in the schema.
    /// </summary>
    public partial class OsaLoginResult1
    {
        private int _Column0;

        public OsaLoginResult1()
        {
        }

    
        /// <summary>
        /// There are no comments for Column0 in the schema.
        /// </summary>
        [Column(Name = @"column0", Storage = "_Column0", DbType = "INT NOT NULL")]
        public int Column0
        {
            get
            {
                return this._Column0;
            }
            set
            {
                if (Object.Equals(this._Column0, value) == false)
                {
                    this._Column0 = value;
                }
            }
        }
      }


    /// <summary>
    /// There are no comments for OsaLoginuserResult in the schema.
    /// </summary>
    public partial class OsaLoginuserResult
    {
        private int _Column0;

        public OsaLoginuserResult()
        {
        }

    
        /// <summary>
        /// There are no comments for Column0 in the schema.
        /// </summary>
        [Column(Name = @"column0", Storage = "_Column0", DbType = "INT NOT NULL")]
        public int Column0
        {
            get
            {
                return this._Column0;
            }
            set
            {
                if (Object.Equals(this._Column0, value) == false)
                {
                    this._Column0 = value;
                }
            }
        }
      }

    /// <summary>
    /// There are no comments for OsaLoginuserResult1 in the schema.
    /// </summary>
    public partial class OsaLoginuserResult1
    {
        private int _Column0;

        public OsaLoginuserResult1()
        {
        }

    
        /// <summary>
        /// There are no comments for Column0 in the schema.
        /// </summary>
        [Column(Name = @"column0", Storage = "_Column0", DbType = "INT NOT NULL")]
        public int Column0
        {
            get
            {
                return this._Column0;
            }
            set
            {
                if (Object.Equals(this._Column0, value) == false)
                {
                    this._Column0 = value;
                }
            }
        }
      }
}

namespace UserContext
{

    /// <summary>
    /// There are no comments for UserContext.Userstable in the schema.
    /// </summary>
    [Table(Name = @"dbo.userstable")]
    public partial class Userstable
    {
        #pragma warning disable 0649

        private string _Username;

        private string _Password;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        #endregion

        public Userstable()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Username in the schema.
        /// </summary>
        [Column(Name = @"username", Storage = "_Username", DbType = "NVARCHAR(50)")]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                if (this._Username != value)
                {
                    this._Username = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [Column(Name = @"password", Storage = "_Password", DbType = "NVARCHAR(50)")]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if (this._Password != value)
                {
                    this._Password = value;
                }
            }
        }
    }

}