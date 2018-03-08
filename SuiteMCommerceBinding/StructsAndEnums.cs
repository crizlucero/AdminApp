using System;

namespace SuiteMCommerceBinding
{
    public enum Environment {
        EnvironmentSANDBOX,
        EnvironmentDEV,
        EnvironmentQA,
        EnvironmentPROD
    }

    public enum PaymentType {
        PaymentTypeC,
        PaymentTypeTo3M,
        PaymentTypeTo6M,
        PaymentTypeTo9M,
        PaymentTypeTo12M
    }

    public enum Currency {
        CurrencyMXN,
        CurrencyUSD
    }
}
