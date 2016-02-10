/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */
using OpenNos.Core;

namespace OpenNos.Data
{
    public class User
    {
        #region Properties

        public string Name { get; set; }

        public string PasswordDecrypted
        {
            get
            {
                return LoginEncryption.sha256(LoginEncryption.GetPassword(PasswordEncrypted));
            }
        }

        public string PasswordEncrypted { get; set; }

        public string Unknown { get; set; }

        #endregion
    }
}