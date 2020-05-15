using eProdaja.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Mobile
{
    public static class CartService
    {
        public static Dictionary<int, ProizvodDetailViewModel> Cart { get; set; } = new Dictionary<int, ProizvodDetailViewModel>();
    }
}
