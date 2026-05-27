// Price.cs — Kata 1: DRY — Value Object
public sealed record Price
{
    public decimal Value { get; }
    private Price(decimal value) => Value = value;

    public static Result<Price> Create(decimal value)
    {
        // TODO: validar value > 0
        //       → Result<Price>.Fail("El precio debe ser mayor a 0.")

        // TODO: validar value <= 1_000_000
        //       → Result<Price>.Fail("El precio excede el máximo permitido.")

        // Si válido:
        //       → Result<Price>.OK(new Price(value))

        //throw new NotImplementedException();

        if (value > 0 && value <= 1_000_000) return Result<Price>.OK(new Price(value));
        else if (value <= 0) return Result<Price>.Fail("El precio debe ser mayor a 0.");
        else return Result<Price>.Fail("El precio excede el máximo permitido.");
    }

    public override string ToString() => $"${Value:N2}";
}
