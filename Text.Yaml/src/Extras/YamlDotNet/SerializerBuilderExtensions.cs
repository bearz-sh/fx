using Bearz.Extra.YamlDotNet;

using YamlDotNet.Serialization;

namespace Bearz.Extras.YamlDotNet;

public static class SerializerBuilderExtensions
{
    public static SerializerBuilder WithStringQuotingEmitter(this SerializerBuilder builder)
        => builder.WithEventEmitter((inner) => new StringQuotingEmitter(inner));
}