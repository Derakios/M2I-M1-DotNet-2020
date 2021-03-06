﻿using CoursService.Core;
using M2I.Diagnostics;
using M2I.Diagnostics.EventLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CoursService
{
    public partial class Service1 : ServiceBase
    {
        #region Fields
        
        /// <summary>
        ///     Instance du service.
        /// </summary>
        private readonly MonService _Service;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="Service1"/>.
        /// </summary>
        public Service1()
        {
            this.InitializeComponent();
            Loggers.AvaillableLoggers.Add(new FileLogger()
            {
                Source = ".\\logfile.log"
            });
            Loggers.AvaillableLoggers.Add(new EventLogger()
            {
                Name = "Image Resizer Service",
                Source = "Image Resizer Service"
            });

            this._Service = new MonService(@"C:\TMP\INPUT", "C:\\TMP\\OUTPUT");
            //Permet d'accepter la mise en pause et la reprise du service.
            this.CanPauseAndContinue = true;
        }

        #endregion

        #region Methods

        protected override void OnStart(string[] args) => this._Service.Start();

        protected override void OnStop() => this._Service.Stop();

        protected override void OnPause() => this._Service.Pause();

        protected override void OnContinue() => this._Service.Continue();

        #endregion
    }
}
