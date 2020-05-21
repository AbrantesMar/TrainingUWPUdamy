using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Info
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

        }
        private static InfoListVM _infoListVM;
        public static InfoListVM InfoListVM
        {
            get 
            {
                if (_infoListVM == null)
                    _infoListVM = new InfoListVM();
                return _infoListVM; 
            }
        }
    }
}
