﻿/*flexberryautogenerated="true"*/
namespace IIS.PMZ
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ЗакупкаТМЦL : BaseListForm<ЗакупкаТМЦ>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ЗакупкаТМЦL() : base(ЗакупкаТМЦ.Views.ЗакупкаТМЦL)
        {
            EditPage = ЗакупкаТМЦE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/ZakupkaTMC/ZakupkaTMCL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
