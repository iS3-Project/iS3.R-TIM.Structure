using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Windows;

using iS3.Core;
using iS3.Core.Serialization;
using iS3.RTIM_Structure.Serialization;
namespace iS3.RTIM_Structure
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

    public class Secondlining : DGObject
    {
        public string concretetype { get; set; }
        public double thickness { get; set; }
        public double radius_roof { get; set; }
        public double radius_foot { get; set; }
        public double radius_invert { get; set; }
        public double length { get; set; }

        public Secondlining()
        {
            //Geologies = new List<Secondlining>();
        }

        public Secondlining(DataRow rawData)
            :base(rawData)
        {
            //Geologies = new List<Secondlining>();
        }

        public override bool LoadObjs(DGObjects objs)
        {
            NATMstrctureDGObjectLoader loader = new NATMstrctureDGObjectLoader();
            bool success = loader.LoadSecondlining(objs);
            return success;
        }
        //public override string ToString()
        //{
        //    string str = base.ToString();

        //    string str1 = string.Format(
        //        ", Top={0}, Base={1}, Mileage={2}, Type={3}, Geo=",
        //        Top, Base, Mileage, Type);
        //    str += str1;

        //    foreach (var geo in Geologies)
        //    {
        //        str += geo.StratumID + ",";
        //    }

        //    return str;
        //}

        public override List<DataView> tableViews(IEnumerable<DGObject> objs)
        {
            List<DataView> dataViews = base.tableViews(objs);
            //if (parent.rawDataSet.Tables.Count > 1)
            //{
            //    DataTable table = parent.rawDataSet.Tables[1];
            //    string filter = idFilter(objs);
            //    DataView view = new DataView(table, filter, "[SecondliningID]",
            //        DataViewRowState.CurrentRows);
            //    dataViews.Add(view);
            //}
            return dataViews;
        }

        //string idFilter(IEnumerable<DGObject> objs)
        //{
        //    string sql = "SecondliningID in (";
        //    foreach (var obj in objs)
        //    {
        //        sql += obj.id.ToString();
        //        sql += ",";
        //    }
        //    sql += ")";
        //    return sql;
        //}

        public override List<FrameworkElement> chartViews(
            IEnumerable<DGObject> objs, double width, double height)
        {
            List<FrameworkElement> charts = new List<FrameworkElement>();

            //List<Secondlining> bhs = new List<Secondlining>();
            //foreach (Secondlining bh in objs)
            //{
            //    if (bh != null && bh.Geologies.Count > 0)
            //        bhs.Add(bh);
            //}

            //Domain geologyDomain = Globals.project.getDomain(DomainType.Geology);
            //DGObjectsCollection strata = geologyDomain.getObjects("Stratum");

            //SecondliningCollectionView bhsView = new SecondliningCollectionView();
            //bhsView.Name = "Geology";
            //bhsView.Secondlinings = bhs;
            //bhsView.Strata = strata;
            //bhsView.ViewerHeight = height;
            //bhsView.RefreshView();
            //bhsView.UpdateLayout();
            //charts.Add(bhsView);

            return charts;
        }
    }
}