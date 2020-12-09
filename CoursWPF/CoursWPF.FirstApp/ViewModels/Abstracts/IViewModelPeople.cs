﻿using CoursWPF.FirstApp.Models;
using CoursWPF.MVVM.Abstracts;
using CoursWPF.MVVM.ViewModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CoursWPF.FirstApp.ViewModels.Abstracts
{
    public interface IViewModelPeople : IViewModelList<Person>
    {

    }
}
