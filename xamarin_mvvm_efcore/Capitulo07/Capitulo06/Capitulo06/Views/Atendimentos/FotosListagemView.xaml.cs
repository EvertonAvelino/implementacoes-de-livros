﻿using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capitulo06.Views.Atendimentos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FotosListagemView : ContentPage
	{
		public FotosListagemView (Atendimento atendimento)
		{
			InitializeComponent ();
		}
	}
}