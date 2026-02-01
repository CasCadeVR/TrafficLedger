namespace TrafficLedger.Desktop.Contracts.Enums
{
    /// <summary>
    /// Контекст использования транспортной карточки 
    /// </summary>
    public enum TransportCardRoleContext
    {
        /// <summary>
        /// Карточка в списке транспорта владельца (Просмотр штрафов)
        /// </summary>
        OwnerList,

        /// <summary>
        /// Карточка в списке привязанных ТС к водителю
        /// </summary>
        DriverOwnershipList,

        /// <summary>
        /// Карточка в списке всех транспортов, исходя из роли (Всё)
        /// </summary>
        RoleList
    }
}