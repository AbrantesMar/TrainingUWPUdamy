using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class MainInfo
    {
        public static InfoList GetInfos()
        {
            var infoList = new InfoList();
            infoList.Infos = new System.Collections.ObjectModel.ObservableCollection<TruckInfo>()
            {
                new TruckInfo
                {
                    ID = "1",
                    Name = "Taco Talent",
                    Style = "Mexican"
                },
                new TruckInfo
                {
                    ID = "2",
                    Name = "Cake Shack",
                    Style = "Desserts"
                },
                new TruckInfo()
                {
                    ID="3",
                    Name ="Ice Heaven",
                    Style = "Cold Drinks"
                }
            };
            return infoList;
        }
        public static IEnumerable<TruckInfo> GetInfosData()
        {
            return new TruckInfo[]
            {
                new TruckInfo
                {
                    ID = "1",
                    Name = "Taco Talent",
                    Style = "Mexican"
                },
                new TruckInfo
                {
                    ID = "2",
                    Name = "Cake Shack",
                    Style = "Desserts"
                },
                new TruckInfo()
                {
                    ID = "3",
                    Name = "Ice Heaven",
                    Style = "Cold Drinks"
                }
            };
        }

        public static TruckInfo GetInfo()
        {
            return new TruckInfo
            {
                ID = "1",
                Name = "Taco Talent",
                Style = "Mexican"
            };
        }
    }
}
