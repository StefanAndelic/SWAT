using System;
using FreshMvvm;
using SWATProject.Models;

namespace SWATProject.PageModels
{
    public class SWATLeaderProfilePageModel : FreshBasePageModel
    {

        public string language { get; set; }

        public string Language
        {
            get { return language; }
            set
            {

                language = value;
            }
        }

        public string hobbies { get; set; }

        public string Hobbies
        {
            get { return hobbies; }
            set
            {

                hobbies = value;
            }
        }

        public string studying { get; set; }

        public string Studying
        {
            get { return studying; }
            set
            {

                studying = value;
            }
        }

        SWATLeader _leader;

        public SWATLeaderProfilePageModel(SWATLeader leader)
        {
            _leader = leader;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            _leader = (SWATLeader)initData;
            Language = _leader.Language;
            Hobbies = _leader.Hobbies;
            Studying = _leader.Education;
        }

    }
}
