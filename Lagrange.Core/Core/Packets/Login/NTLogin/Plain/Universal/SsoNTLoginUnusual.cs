using ProtoBuf;

namespace Lagrange.Core.Core.Packets.Login.NTLogin.Plain.Universal;

// ReSharper disable once InconsistentNaming

[ProtoContract]
internal class SsoNTLoginUnusual
{
    [ProtoMember(2)] public byte[]? Sig { get; set; }
}