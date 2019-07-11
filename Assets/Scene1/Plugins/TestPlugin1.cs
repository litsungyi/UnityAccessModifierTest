


namespace Scene1
{
    public enum PublicEnum
    {
        EnumValue
    }

    internal enum InternalEnum
    {
        EnumValue
    }

    enum DefaultEnum // NOTE: enum 的預設存取修飾詞為 internal
    {
        EnumValue
    }

    // NOTE: enum 不可以為 protected, private, protected internal, private internal
    // Description: enum 繼承 System.Enum 因此 enum 是 value-type 因此無法繼承（也就是sealed）
    // NOTE: enum value 


}