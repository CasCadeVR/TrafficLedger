namespace TrafficLedger.Entities.Typing
{
    /// <summary>
    /// Типы сущностей
    /// </summary>
    public static class EntityTypes
    {
        public const string FinePaymentType = nameof(Fine);
        public const string ParkingSessionPaymentType = nameof(ParkingSession);

        public const string TransportType = nameof(Transport);
        public const string DriverLicenseType = nameof(DriverLicense);
        public const string DriverType = nameof(Driver);
    }
}
