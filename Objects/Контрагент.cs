﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.PMZ
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Контрагент.
    /// </summary>
    // *** Start programmer edit section *** (Контрагент CustomAttributes)

    // *** End programmer edit section *** (Контрагент CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КонтрагентE", new string[] {
            "Наименование as \'Наименование\'",
            "Договор as \'Договор\'",
            "Договор.Номер as \'Номер\'"})]
    [View("КонтрагентL", new string[] {
            "Наименование as \'Наименование\'",
            "Договор.Номер as \'Номер\'"})]
    public class Контрагент : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private IIS.PMZ.Договор fДоговор;
        
        // *** Start programmer edit section *** (Контрагент CustomMembers)

        // *** End programmer edit section *** (Контрагент CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Наименование CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Наименование Get start)

                // *** End programmer edit section *** (Контрагент.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Контрагент.Наименование Get end)

                // *** End programmer edit section *** (Контрагент.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Наименование Set start)

                // *** End programmer edit section *** (Контрагент.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Контрагент.Наименование Set end)

                // *** End programmer edit section *** (Контрагент.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Контрагент.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Договор CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Договор CustomAttributes)
        public virtual IIS.PMZ.Договор Договор
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Договор Get start)

                // *** End programmer edit section *** (Контрагент.Договор Get start)
                IIS.PMZ.Договор result = this.fДоговор;
                // *** Start programmer edit section *** (Контрагент.Договор Get end)

                // *** End programmer edit section *** (Контрагент.Договор Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Договор Set start)

                // *** End programmer edit section *** (Контрагент.Договор Set start)
                this.fДоговор = value;
                // *** Start programmer edit section *** (Контрагент.Договор Set end)

                // *** End programmer edit section *** (Контрагент.Договор Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КонтрагентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонтрагентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонтрагентE", typeof(IIS.PMZ.Контрагент));
                }
            }
            
            /// <summary>
            /// "КонтрагентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонтрагентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонтрагентL", typeof(IIS.PMZ.Контрагент));
                }
            }
        }
    }
}
