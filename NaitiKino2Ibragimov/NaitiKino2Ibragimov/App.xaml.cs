﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NaitiKino2Ibragimov.Models;

namespace NaitiKino2Ibragimov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<User> Users = new List<User>();
        public static NaitiKinoEntities DB = new NaitiKinoEntities();
        public static User LoggedUser;
    }
}
