﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private readonly IConfiguration _configuration;
        //private string _mailTo = "admin@mycompany.com";
        //private string _mailFrom = "noreply@mycompany.com";

        public LocalMailService(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration)); 
        }

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from {_configuration["mailSttings:mailToAddress"]} to  {_configuration["mailSttings:mailFormAddress"]} with local mail service");
            Debug.WriteLine($"subject :{subject}");
            Debug.WriteLine($"message :{message}");
        }
    }
}
