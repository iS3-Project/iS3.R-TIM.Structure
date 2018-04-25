using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iS3.Core;
using iS3.Core.Serialization;

namespace iS3.RTIM_Structure.Serialization
{
    #region Copyright Notice
    //************************  Notice  **********************************
    //** This file is part of iS3
    //**
    //** Copyright (c) 2015 Tongji University iS3 Team. All rights reserved.
    //**
    //** This library is free software; you can redistribute it and/or
    //** modify it under the terms of the GNU Lesser General Public
    //** License as published by the Free Software Foundation; either
    //** version 3 of the License, or (at your option) any later version.
    //**
    //** This library is distributed in the hope that it will be useful,
    //** but WITHOUT ANY WARRANTY; without even the implied warranty of
    //** MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    //** Lesser General Public License for more details.
    //**
    //** In addition, as a special exception,  that plugins developed for iS3,
    //** are allowed to remain closed sourced and can be distributed under any license .
    //** These rights are included in the file LGPL_EXCEPTION.txt in this package.
    //**
    //**************************************************************************
    #endregion
    public class NATMstrctureDGObjectLoader
    {
        protected NATMstrctureDbDataLoader _dbLoader;

        public NATMstrctureDGObjectLoader()
        {
            _dbLoader = new NATMstrctureDbDataLoader();
        }
        public bool LoadSecondlining(DGObjects objs)
        {
            DGObjectsDefinition def = objs.definition;
            if (def == null)
                return false;
            bool success = _dbLoader.ReadSecondlining(objs,
                def.TableNameSQL, def.ConditionSQL, def.OrderSQL);
            return success;
        }

      
    }
}
