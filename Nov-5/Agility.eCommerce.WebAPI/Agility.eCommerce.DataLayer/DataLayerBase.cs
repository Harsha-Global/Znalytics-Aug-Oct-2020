using System;
using System.Collections.Generic;
using System.Linq;

namespace Agility.eCommerce.DataLayer
{
    public abstract class DataLayerBase<T> where T : class
    {
        public T CheckNullAndReturn(T modelObject)
        {
            if (modelObject == null)
            {
                return null;
            }
            else
            {
                return modelObject;
            }
        }
    }
}
