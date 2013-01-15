/*
 *  Pkcs11Interop - Open-source .NET wrapper for unmanaged PKCS#11 libraries
 *  Copyright (C) 2012 Jaroslav Imrich <jimrich(at)jimrich(dot)sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3
 *  as published by the Free Software Foundation.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace Net.Pkcs11Interop.HighLevelAPI.MechanismParams
{
    /// <summary>
    /// Parameters for the general-length MACing mechanisms (DES, DES3, CAST, CAST3, CAST128 (CAST5), IDEA, CDMF and AES), the general length HMACing mechanisms (MD2, MD5, SHA-1, SHA-256, SHA-384, SHA-512, RIPEMD-128 and RIPEMD-160) and the two SSL 3.0 MACing mechanisms (MD5 and SHA-1)
    /// </summary>
    public class CkMacGeneralParams : IMechanismParams
    {
        /// <summary>
        /// Low level mechanism parameters
        /// </summary>
        private LowLevelAPI.MechanismParams.CK_MAC_GENERAL_PARAMS _lowLevelStruct = new LowLevelAPI.MechanismParams.CK_MAC_GENERAL_PARAMS();

        /// <summary>
        /// Length of the MAC produced, in bytes
        /// </summary>
        public uint MacLength
        {
            get
            {
                return _lowLevelStruct.MacLength;
            }
            set
            {
                _lowLevelStruct.MacLength = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the CkMacGeneralParams class.
        /// </summary>
        public CkMacGeneralParams()
        {
            _lowLevelStruct.MacLength = 0;
        }
        
        #region IMechanismParams
        
        /// <summary>
        /// Converts object to low level mechanism parameters
        /// </summary>
        /// <returns>Low level mechanism parameters</returns>
        public object ToLowLevelParams()
        {
            return _lowLevelStruct;
        }
        
        #endregion
    }
}