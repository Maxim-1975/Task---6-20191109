﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class InitContactData
    {
        private string firstname = "";
        private string middlename = "";
        private string lastname = "";
        public InitContactData()
        {
            
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }
        public string Lastename
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
}