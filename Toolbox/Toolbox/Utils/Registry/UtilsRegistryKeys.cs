﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace NetOffice.DeveloperToolbox.Utils.Registry
{
    public class UtilsRegistryKeys : IEnumerable<UtilsRegistryKey>
    {
        #region Member

        UtilsRegistryKey _parent;
        
        #endregion
           
        #region Construction

        internal UtilsRegistryKeys(UtilsRegistryKey parent)
        {
            _parent = parent;
        }

        #endregion

        #region Properties

        public int Count
        {
            get
            {
                RegistryKey key = _parent.Open();
                int count = key.SubKeyCount;
                key.Close();
                return count;
            }
        }
         
        public UtilsRegistryKey this[string name]
        {
            get
            {
                RegistryKey key = _parent.Open();
                UtilsRegistryKey newKey = new UtilsRegistryKey(_parent.Root, key, _parent.Path + "\\" + name);
                key.Close();
                return newKey;
            }
        }

        #endregion

        #region Methods

        public UtilsRegistryEntry Add(RegistryValueKind kind, object value)
        {
            RegistryKey key = _parent.Open(true);
            string[] names = key.GetValueNames();
            string name = GetNewStringValueName(names, kind.ToString());
            key.SetValue(name, value, kind);
            key.Close();
            return new UtilsRegistryEntry(_parent, name);
        }

        private static string GetNewStringValueName(string[] names, string kind)
        {
            string result = "#Neu " + kind.ToString();
            int i = 1;
            while (true)
            {
                bool found = false; ;
                foreach (string item in names)
                {
                    if (item == result)
                    { 
                        found = true;
                        break;
                    }
                }
                if (!found)
                    break;
                else
                {
                    result = "#Neu " + kind.ToString() + i.ToString();
                    i++;
                }
            }
            return result;
        }
            
        #endregion

        #region IEnumerable<UtilsRegistryKey>

        public IEnumerator<UtilsRegistryKey> GetEnumerator()
        {
            RegistryKey key = _parent.Open();
            if (null != key)
            {
                string[] valueNames = key.GetSubKeyNames();
                foreach (string item in valueNames)
                    yield return this[item];
                key.Close();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            RegistryKey key = _parent.Open();
            if (null != key)
            {
                string[] valueNames = key.GetSubKeyNames();
                foreach (string item in valueNames)
                    yield return this[item];
                key.Close();
            }
        }

        #endregion
    }
}
