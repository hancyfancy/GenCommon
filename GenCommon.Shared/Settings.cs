﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenCommon.Shared
{
    public static class Settings
    {
        public static readonly string SmtpHost = "smtp.zoho.com.au";
        public static readonly int SmtpPort = 587;
        public static readonly bool SmtpUseSsl = true;
        public static readonly string SmtpSender = "malavdea@zohomail.com.au";
        public static readonly string SmtpPassword = "wSxzMhNxJ1NU";
        public static readonly int EmailValidationSize = 200;
        public static readonly int PhoneValidationSize = 6;
        public static readonly string SmsSender = "malavdea";
        public static readonly string ClickSendUsername = "atalmalavdework@gmail.com";
        public static readonly string ClickSendApiKey = "F057035E-8019-E792-987F-6466C81E6B36";
    }
}
