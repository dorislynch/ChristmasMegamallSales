using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Christmas.Megamall.Sales.RNChristmasMegamallSales
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNChristmasMegamallSalesModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNChristmasMegamallSalesModule"/>.
        /// </summary>
        internal RNChristmasMegamallSalesModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNChristmasMegamallSales";
            }
        }
    }
}
