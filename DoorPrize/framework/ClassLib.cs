using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using DoorPrize.framework;


namespace DoorPrize
{
    public class ResultObj : IDisposable
    {
        private bool _status;
        private object _result;
        private string _errDesc;

        public void Dispose()
        {
            this._status = false;
            this._errDesc = null;
            this._result = null;
            GC.Collect();
        }

        public ResultObj()
        {
            Status = false;
            Result = null;
            ErrorDesc = "";
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public object Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string ErrorDesc
        {
            get { return _errDesc; }
            set { _errDesc = value; }
        }
    }

    public class Json2D
    {
        public string ID { get; set; }
        public object Value { get; set; }
    }

    public enum enumCurrency : int
    {
        IDR = 0,
        USD = 1,
        EUR = 2
    }

    public enum enumDuration
    {
        Yearly,
        TriAnnual,
        Quarterly,
        Monthly
    }

    public enum enumTaxInvStatus
    {
        OPEN,
        WIMAX,
        USED
    }

    public enum enumInvHistType
    {
        PreviewInvoice,
        PrintInvoice,
        ReprintInvoice,
        PreviewCN,
        PrintCN,
        ReprintCN
    }

    public enum enumCaller
    {
        Proforma,
        CalculateSO
    }

    public enum enumRateNotReady
    {
        Ready,
        Created,
        Failed
    }
    
    public class GridSetSchedule
    {
        public bool Active { get; set; }
        public string AN8 { get; set; }
        public string ALPH { get; set; }
        public bool BAST { get; set; }
    }

    public class Helper
    {
        public Helper()
        {

        }
        public  const string MSG_LOST_SESSION = "Your session has been lost, please refresh your page by pressing F5 or reload the page.";
        public  const string MSG_CONTACT_ADMIN = "Technical error appear, please contact Helpdesk IT.";
        public static int GetWeekInMonth(DateTime date)
        {
            DateTime tempdate = date.AddDays(-date.Day + 1);

            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNumStart = ciCurr.Calendar.GetWeekOfYear(tempdate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int result = weekNum - weekNumStart + 1;
            if (new DateTime(date.Year, date.Month, 1).DayOfWeek == DayOfWeek.Saturday || new DateTime(date.Year, date.Month, 1).DayOfWeek == DayOfWeek.Sunday)
                result--;
            return result;
        }

        public static int GetTotalWeekofMonth(int year, int month)
        {
            int tglakhir = DateTime.DaysInMonth(year, month);
            return GetWeekInMonth(new DateTime(year, month, tglakhir));
        }

        public static string GetUserID()
        {            
            string userid = string.Empty;
            string site =  ConfigManager.GetSetting("site");
            try
            {
                using (SPSite oSiteCollection = new SPSite(site))
                {
                    using (SPWeb oWebsite = oSiteCollection.OpenWeb())
                    {
                        userid = oWebsite.CurrentUser.LoginName;
                    }
                }
            }
            catch (Exception ex)
            {
                userid = ex.Message.ToString();
            }

            string _str = @"ROOT\";

            userid = userid.Replace(_str, string.Empty);

            //userid = ConfigManager.GetSetting("userID");

            // userid = "bintoro.yuwono";

            // userid = "sp_admin";
            // userid = "asri.dwitiya";

            // userid = "jerfi.tan";
            // SI
            // userid = "Effendy.Thendean";
            // userid = "Cornelia.Agustin";
            // userid = "Jeffrey.Tandra";
            // userid = "elizabeth.dora";
            // userid = "idha.setyani";
            // userid = "christiani.purwaning";
            // userid = "inneke.abdullah";
            // userid = "twentya.gultom";
            // userid = "charlie.wijaya";
            // userid = "mela.sari";
            // userid = "elis.yulianti";
            // userid = "Rickhy.Vilianto";
            // userid = "dian.sumbung";

            // userid = "ari.darmaji";
            // userid = "caesar.pradana";
            // userid = "sri.hutami";
            // userid = "Susanti";
            // userid = "herry.priasmoro";
            // userid = "silvianita.permanda";
            // userid = "halik.wihasan";
            // userid = "Raymond.Themmy";
            // userid = "Doddy.Indrajaya";
            // userid = "jovany.aditya";
            // userid = "paskalia.mariana";
            // userid = "ibrahim.asyari";

            // PM 
            // userid = "Rudhyanto.Erawan";
            // userid = "qurrata.akyuni";

            // userid = "rika.shoba";

            // CS
            // userid = "Cresentia.Yunita";
            // userid = "alverrino.pratama";
            // userid = "Robet.Santoso";
            // userid = "Lydia.Wahyudi";

            // GNPS
            // userid = "Manik.Wirani";
            // userid = "denis.sarumpaet";
            // userid = "rony.budiman";
            // TMI
            // userid = "erlan.prabowo";
            // userid = "huwar.faridi";

            if (userid.Equals("christiani.purwaning"))
            {
                userid = userid + "sih";
            }

            //userid = "angga.hantara";
            return userid;
        }

        public static string GetEmail()
        {
            string email = "";
            string site = ConfigManager.GetSetting("site");
            try
            {
                using (SPSite oSiteCollection = new SPSite(site))
                {
                    using (SPWeb oWebsite = oSiteCollection.OpenWeb())
                    {
                        email = oWebsite.CurrentUser.Email;
                    }
                }
            }
            catch (Exception ex)
            {
                email = ex.Message.ToString();
            }
            return email;
        }

        public static ResultObj GetUsers()
        {
            ResultObj result = new ResultObj();
            List<SPUser> listuser = new List<SPUser>();
            string site = ConfigManager.GetSetting("site");
            try
            {
                using (SPSite oSiteCollection = new SPSite(site))
                {
                    using (SPWeb oWebsite = oSiteCollection.OpenWeb())
                    {
                        //userid = oWebsite.CurrentUser.LoginName;
                        foreach (SPUser user in oWebsite.AllUsers)
                        {
                            listuser.Add(user);
                        }
                    }
                }
                result.Status = true;
                result.ErrorDesc = "Success";
                result.Result = listuser;
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ErrorDesc = ex.Message;
                result.Result = null;
            }            
            return result;            
        }

        public static string GetManager()
        {
            string strsite = ConfigManager.GetSetting("site");
            using (SPSite site = new SPSite(strsite))
            {
                string manager = string.Empty;
                SPServiceContext serviceContext = SPServiceContext.GetContext(site);//Get the context for this site
                UserProfileManager profileManger = new UserProfileManager(serviceContext);
                SPUser user = SPContext.Current.Web.CurrentUser; //Get the current logged in user 
                try
                {
                    UserProfile prof = profileManger.GetUserProfile(user.LoginName); //Get the profile for the current logged in user
                    manager = (prof[PropertyConstants.Manager].Value == null)
                    ? "" : prof[PropertyConstants.Manager].Value.ToString(); //Get the manager 
                }
                catch (Exception)
                {
                    manager = "Manager was not found";
                }
                return manager;
            }
        }

        public static double ToJulianDate(DateTime date)
        {
            return date.ToOADate() + 2415018.5;
        }

        public static DataTable GetControlGrant()
        {
            DataTable dtretval = new DataTable();
            using (SQLDataAccess da = new SQLDataAccess())
            {
                dtretval = da.ExecuteQuery(@"select rd.Page,rd.ControlID from UserGroup ug with(nolock)
                        join Role_H rh on ug.GroupID = rh.GroupID
                        join Role_D rd on rd.RoleID = rh.RoleID where 
                        ug.UserName = '" + GetUserID() + "'", null);
               
            }
            return dtretval;
        }

        public static bool isControlGranted(string controlID)
        {
            using (SQLDataAccess da = new SQLDataAccess())
            {
                if (da.ExecuteQuery("exec sp_GetUserControl '" + GetUserID() + "','" + controlID + "'", null).Rows.Count > 0)
                {                    
                    return true;
                }
            }
            return false;
        }

        public static void InsertToInvHistory(IDataAccess daSQL, IDbTransaction transql, int InvNo, string dcto, int lnid, int doco, string prefix, int stroke, string userid, string invhistype)
        {
            string qInsertHistory = "Insert Into HistoryInvoice values(" + InvNo + ",'" + dcto + "'," + lnid + "," + doco + ",'" + prefix + "','" + stroke + "','" + userid + "',getdate(),'" + invhistype + "')";
            if (daSQL.ExecuteNonQuery(qInsertHistory, null, transql) == 0)
                throw new ApplicationException("Failed when inserting data to History Invoice, this transaction was aborted.");
        }

        /// <summary>
        /// satuan array list
        /// </summary>
        private static readonly string[] _satuan = new string[10]
        {
            "nol", "satu", "dua",
            "tiga", "empat",
            "lima", "enam", "tujuh",
            "delapan", "sembilan"
        };

        /// <summary>
        /// belasan array list
        /// </summary>
        private static readonly string[] _belasan = new string[10]
        {
            "sepuluh", "sebelas", "dua belas",
            "tiga belas", "empat belas",
            "lima belas", "enam belas",
            "tujuh belas",
            "delapan belas", "sembilan belas"
        };

        /// <summary>
        /// puluhan array list
        /// </summary>
        private static readonly string[] _puluhan = new string[10]
        {
            "", "", "dua puluh",
            "tiga puluh", "empat puluh",
            "lima puluh", "enam puluh",
            "tujuh puluh", "delapan puluh",
            "sembilan puluh"
        };

        /// <summary>
        /// ribuan array list
        /// </summary>
        private static readonly string[] _ribuan = new string[5]
        {
            "", "ribu", "juta",
            "milyar", "triliyun"
        };

        /// <summary>
        /// say number in indonesian.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns></returns>
        public static string Terbilang(Decimal d)
        {
            string strResult = "";
            Decimal frac = d - Decimal.Truncate(d);

            if (Decimal.Compare(frac, 0.0m) != 0)
                strResult = Terbilang(Decimal.Round(frac * 100)) + " sen";
            else
                strResult = "rupiah";

            int nDigit = 0;
            int nPos = 0;

            string strTemp = Decimal.Truncate(d).ToString();

            for (int i = strTemp.Length; i > 0; i--)
            {
                nDigit = Convert.ToInt32(strTemp.Substring(i - 1, 1));
                nPos = (strTemp.Length - i) + 1;
                switch (nPos % 3)
                {
                    case 1:
                        bool bAllZeros = false;
                        string tmpBuff = "";
                        if (i == 1)
                            tmpBuff = _satuan[nDigit] + " ";
                        else if (strTemp.Substring(i - 2, 1) == "1")
                            tmpBuff = _belasan[nDigit] + " ";
                        else if (nDigit > 0)
                            tmpBuff = _satuan[nDigit] + " ";
                        else
                        {
                            bAllZeros = true;
                            if (i > 1)
                                if (strTemp.Substring(i - 2, 1) != "0")
                                    bAllZeros = false;
                            if (i > 2)
                                if (strTemp.Substring(i - 3, 1) != "0")
                                    bAllZeros = false;
                            tmpBuff = "";
                        }

                        if ((!bAllZeros) && (nPos > 1))
                            if ((strTemp.Length == 4) &&
                            (strTemp.Substring(0, 1) == "1"))
                                tmpBuff =
                                "se" +
                                _ribuan[(int)Decimal.Round(nPos / 3m)] + " ";
                            else
                                tmpBuff +=
                                _ribuan[(int)Decimal.Round(nPos / 3)] + " ";
                        strResult = tmpBuff + strResult;
                        break;
                    case 2:
                        if (nDigit > 0)
                            strResult =
                            _puluhan[nDigit] + " " + strResult;
                        break;
                    case 0:
                        if (nDigit > 0)
                            if (nDigit == 1)
                                strResult =
                                "seratus " + strResult;
                            else
                                strResult =
                                _satuan[nDigit] + " ratus " + strResult;
                        break;
                }
            }
            strResult = strResult.Trim().ToLower();
            if (strResult.Length > 0)
            {
                strResult = strResult.Substring(0, 1).ToUpper() +
                strResult.Substring(1, strResult.Length - 1);
            }

            return strResult;
        }

        //public static string CreateParam(System.Collections.Generic.Dictionary<string, object> parameters)
        //{
        //    SHA1CryptoServiceProvider
        //}

        public static class NumberToEnglish
    {
        public static String changeNumericToWords(double numb)
        {
            String num = numb.ToString();
            return changeToWords(num, false);
        }
   public static String changeCurrencyToWords(String numb)
   {
    return changeToWords(numb, true);
   }
   public static String changeNumericToWords(String numb)
   {
    return changeToWords(numb, false);
   }
   public static String changeCurrencyToWords(decimal numb)
   {
    return changeToWords(numb.ToString(), true);
   }
   private static String changeToWords(String numb, bool isCurrency)
   {
   String val = "", wholeNo = numb, points = "", andStr = "", pointStr="";
   String endStr = (isCurrency) ? ("Dollars") : ("");
   try
   {
    int decimalPlace = numb.IndexOf(".");
    if (decimalPlace > 0)
    {
     wholeNo = numb.Substring(0, decimalPlace);
     points = numb.Substring(decimalPlace+1);
     if (Convert.ToInt32(points) > 0)
     {
      andStr = (isCurrency)?("and"):("point");// just to separate whole numbers from > points/cents
      endStr = (isCurrency) ? ("Cents "+endStr) : ("");
      pointStr = translateCents(points);
     }
    }
    val = String.Format("{0} {1}{2} {3}",translateWholeNumber(wholeNo).Trim(),andStr,pointStr,endStr);
   }
   catch { ;}
   return val;
  }
   private static String translateWholeNumber(String number)
   {
    string word = "";
    try
    {
     bool beginsZero = false;//tests for 0XX
     bool isDone = false;//test if already translated
     double dblAmt = (Convert.ToDouble(number));
     //if ((dblAmt > 0) && number.StartsWith("0"))
     if (dblAmt > 0)
     {//test for zero or digit zero in a nuemric
      beginsZero = number.StartsWith("0");

      int numDigits = number.Length;
      int pos = 0;//store digit grouping
      String place = "";//digit grouping name:hundres,thousand,etc...
      switch (numDigits)
      {
       case 1://ones' range
        word = ones(number);
        isDone = true;
        break;
       case 2://tens' range
        word = tens(number);
        isDone = true;
        break;
       case 3://hundreds' range
        pos = (numDigits % 3) + 1;
        place = " Hundred ";
        break;
       case 4://thousands' range
       case 5:
       case 6:
        pos = (numDigits % 4) + 1;
        place = " Thousand ";
        break;
       case 7://millions' range
       case 8:
       case 9:
        pos = (numDigits % 7) + 1;
        place = " Million ";
        break;
       case 10://Billions's range
        pos = (numDigits % 10) + 1;
        place = " Billion ";
        break;
       //add extra case options for anything above Billion...
       default:
        isDone = true;
        break;
      }
      if (!isDone)
      {//if transalation is not done, continue...(Recursion comes in now!!)
       word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
       //check for trailing zeros
       if (beginsZero) word = " and " + word.Trim();
      }
      //ignore digit grouping names
      if (word.Trim().Equals(place.Trim())) word = "";
     }
    }
    catch { ;}
    return word.Trim();
   }
   private static String tens(String digit)
   {
    int digt = Convert.ToInt32(digit);
    String name = null;
    switch (digt)
    {
     case 10:
      name = "Ten";
      break;
     case 11:
      name = "Eleven";
      break;
     case 12:
      name = "Twelve";
      break;
     case 13:
      name = "Thirteen";
      break;
     case 14:
      name = "Fourteen";
      break;
     case 15:
      name = "Fifteen";
      break;
     case 16:
      name = "Sixteen";
      break;
     case 17:
      name = "Seventeen";
      break;
     case 18:
      name = "Eighteen";
      break;
     case 19:
      name = "Nineteen";
      break;
     case 20:
      name = "Twenty";
      break;
     case 30:
      name = "Thirty";
      break;
     case 40:
      name = "Fourty";
      break;
     case 50:
      name = "Fifty";
      break;
     case 60:
      name = "Sixty";
      break;
     case 70:
      name = "Seventy";
      break;
     case 80:
      name = "Eighty";
      break;
     case 90:
      name = "Ninety";
      break;
     default:
      if (digt > 0)
      {
       name = tens(digit.Substring(0, 1) + "0") + "" + ones(digit.Substring(1));
      }
      break;
    }
    return name;
   }
   private static String ones(String digit)
   {
    int digt = Convert.ToInt32(digit);
    String name = "";
    switch (digt)
    {
     case 1:
      name = "One";
      break;
     case 2:
      name = "Two";
      break;
     case 3:
      name = "Three";
      break;
     case 4:
      name = "Four";
      break;
     case 5:
      name = "Five";
      break;
     case 6:
      name = "Six";
      break;
     case 7:
      name = "Seven";
      break;
     case 8:
      name = "Eight";
      break;
     case 9:
      name = "Nine";
      break;
    }
    return name;
   }
   private static String translateCents(String cents)
   {
    String cts = "", digit = "", engOne = "";
     for (int i = 0; i < cents.Length; i++)
     {
      digit = cents[i].ToString();
      if (digit.Equals("0"))
      {
       engOne = "Zero";
      }
      else
      {
       engOne = ones(digit);
      }
      cts += " " + engOne;
     }
    return cts;
   }
  }
    }

    public class DataUtils
    {
        public static DataRow CreateRowCopy(DataTable newParentTable, DataRow dataRow)
        {
            DataRow newRow = newParentTable.NewRow();

            for (int index = 0; index < dataRow.Table.Columns.Count; index++)
            {
                newRow[index] = dataRow[index];
            }

            return newRow;
        }

        public static void MoveDataRowUp(DataRow dataRow)
        {
            DataTable parentTable = dataRow.Table;
            int rowIndex = parentTable.Rows.IndexOf(dataRow);

            if (rowIndex > 0)
            {
                DataRow newDataRow = parentTable.NewRow();

                for (int index = 0; index < dataRow.ItemArray.Length; index++)
                {
                    newDataRow[index] = dataRow[index];
                }

                parentTable.Rows.Remove(dataRow);

                parentTable.Rows.InsertAt(newDataRow, rowIndex - 1);

                dataRow = newDataRow;
            }
        }

        public static void MoveDataRowDown(DataRow dataRow)
        {
            DataTable parentTable = dataRow.Table;
            int rowIndex = parentTable.Rows.IndexOf(dataRow);

            if (rowIndex < parentTable.Rows.Count - 1)
            {
                DataRow newDataRow = parentTable.NewRow();

                for (int index = 0; index < dataRow.ItemArray.Length; index++)
                {
                    newDataRow[index] = dataRow[index];
                }

                parentTable.Rows.Remove(dataRow);

                parentTable.Rows.InsertAt(newDataRow, rowIndex + 1);

                dataRow = newDataRow;
            }
        }
    }
    
 }
    //public class MyWindow : Window
    //{
    //    //private Unit width = new Unit(400);

    //    public override Unit Width
    //    {
    //        //get
    //        //{
    //        //    return this.width;
    //        //}
    //        get;
    //        set;
    //    }

    //    //private Unit height = new Unit(400);

    //    public override Unit Height
    //    {
    //        //get
    //        //{
    //        //    return this.height;
    //        //}
    //        get;
    //        set;
    //    }

    //    public string cfgURL { get; set; }
    //    public Ext.Net.Parameter[] cfgParam { get; set; }

    //    private LoadConfig loadConfig;

    //    public override LoadConfig AutoLoad
    //    {
    //        get
    //        {
    //            if (loadConfig != null)
    //            {
    //                return loadConfig;
    //            }
    //            loadConfig = base.AutoLoad;
    //            loadConfig.Url = this.cfgURL;
    //            foreach (Ext.Net.Parameter param in cfgParam)
    //            {
    //                loadConfig.Params.Add(param);
    //            }                
    //            loadConfig.Mode = LoadMode.IFrame;
    //            loadConfig.NoCache = true;
    //            return loadConfig;
    //        }
    //    }
    //}

