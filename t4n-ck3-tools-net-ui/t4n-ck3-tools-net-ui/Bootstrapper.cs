﻿using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using t4n_ck3_tools_net_ui.ViewModels;

namespace T4nCk3ToolsNetUi
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();

            container.Singleton<IWindowManager, WindowManager>();

            container.PerRequest<ShellViewModel>();
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
