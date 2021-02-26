using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace System
{
    public static class ExtensionClass
    {
        public static string ToPersian(this DateTime date)
        {
            PersianCalendar persian = new PersianCalendar();
            int year = persian.GetYear(date);
           int day= persian.GetDayOfMonth(date);
            int month = persian.GetMonth(date);

            return year + "/" + month + "/" + day;
        }
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            string RequestedWithHeader = "X-Requested-With";
            string XmlHttpRequest = "XMLHttpRequest";
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (request.Headers != null)
            {
                return request.Headers[RequestedWithHeader] == XmlHttpRequest;
            }

            return false;
        }

    }
}
