using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.Odbc;

using iS3.Core;
using iS3.Core.Serialization;
using iS3.RTIM_Structure;

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
    public class NATMstrctureDbDataLoader : DbDataLoader
    {

        public NATMstrctureDbDataLoader()
        { }

        // Read Secondlining
        //
        public bool ReadSecondlining(DGObjects objs, string tableNameSQL,
            List<int> objsIDs)
        {
            string conditionSQL = WhereSQL(objsIDs);

            return ReadSecondlining(objs, tableNameSQL, conditionSQL, null);
            return true;
        }

        public bool ReadSecondlining(
            DGObjects objs,
            string tableNameSQL,
            string conditionSQL, 
            string orderSQL)
        {
            try
            {
                //ReadRawData(objs, tableNameSQL, orderSQL, conditionSQL);
                _ReadSecondlining(objs, tableNameSQL, conditionSQL, 
                    orderSQL);
            }
            catch (DbException ex)
            {
                string str = ex.ToString();
                ErrorReport.Report(str);
                return false;
            }
            return true;
        }
        void _ReadSecondlining(
            DGObjects objs,
            string tableNameSQL,
            string conditionSQL,
            string orderSQL)
        {
            ReadRawData(objs, tableNameSQL, orderSQL, conditionSQL);
            DataTable table = objs.rawDataSet.Tables[0];
            foreach (DataRow row in table.Rows)
            {
                if (IsDbNull(row, "ID"))
                    continue;

                Secondlining sl = new Secondlining(row);
                sl.id = ReadInt(row, "ID").Value;
                sl.name = ReadString(row, "ID");
                //sl.name = ReadString(row, "name");
                //sl.fullName = ReadString(row, "FullName");
                //sl.description = ReadString(row, "Description");
                //sl.shape = ReadShape(row);

                //sl.concretetype = ReadString(row, "二衬混凝土型号");
                //sl.thickness = ReadDouble(row, "二衬厚度").Value;
                //sl.radius_roof = ReadDouble(row, "拱顶内轮廓半径").Value;
                //sl.radius_foot = ReadDouble(row, "拱脚内轮廓半径").Value;
                //sl.radius_invert = ReadDouble(row, "仰拱内轮廓半径").Value;
                //sl.length = ReadDouble(row, "二衬长度").Value;

                objs[sl.key] = sl; 
            }
        }


 
    }
}
