using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KoenZomers.UniFi.Api.Responses
{
    /// <summary>
    /// Details of a UniFi device such as an access point or switch
    /// </summary>
    public class UniFiSecurityGateway3P : Device
    {
        /// <summary>
        /// UniFi code that identifies the device type
        /// </summary>
        public new string ExpectedTypeCode { get => Constants.DeviceTypeCodes.UniFiGateway; }

        /// <summary>
        /// The amount of time (in seconds) that the device has been turned on
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        public int UpTime { get; set; }

        /// <summary>
        /// Detailed object of the WAN 1 interface
        /// </summary>
        [JsonProperty(PropertyName = "wan1")]
        public WanInterface WanInterface1 { get; set; }

        /// <summary>
        /// Detailed object of the WAN 2 interface
        /// </summary>
        [JsonProperty(PropertyName = "wan2")]
        public WanInterface WanInterface2 { get; set; }

        /// <summary>
        /// Determine if the type code supplied applies to this object type
        /// </summary>
        /// <returns></returns>
        public override bool IsCorrectType()
        {
            return string.Equals(Type, ExpectedTypeCode, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Determine if the model code supplied applies to this object type
        /// </summary>
        /// <returns></returns>
        public override bool IsCorrectModel()
        {
            return string.Equals(Model, ExpectedModelCode, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    public class WanInterface
    {
        [JsonProperty(PropertyName = "max_speed")]
        public int MaximumSpeed { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string ConnectionType { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ifname")]
        public string InterfaceName { get; set; }

        [JsonProperty(PropertyName = "ip")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName = "netmask")]
        public string NetworkMask { get; set; }

        [JsonProperty(PropertyName = "mac")]
        public string MacAddress { get; set; }

        [JsonProperty(PropertyName = "up")]
        public bool IsUp { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }

        [JsonProperty(PropertyName = "full_duplex")]
        public bool IsFullDuplex { get; set; }

        [JsonProperty(PropertyName = "rx_bytes")]
        public long ReceivedBytes { get; set; }

        [JsonProperty(PropertyName = "rx_dropped")]
        public int ReceivedDroppedPackets { get; set; }

        [JsonProperty(PropertyName = "rx_errors")]
        public int RecievedErrors { get; set; }

        [JsonProperty(PropertyName = "rx_packets")]
        public int ReceivedPackets { get; set; }

        [JsonProperty(PropertyName = "tx_bytes")]
        public long TransmittedBytes { get; set; }

        [JsonProperty(PropertyName = "tx_dropped")]
        public int TransmittedDroppedPackets { get; set; }

        [JsonProperty(PropertyName = "tx_errors")]
        public int TransmittedErrors { get; set; }

        [JsonProperty(PropertyName = "tx_packets")]
        public int TransmittedPackets { get; set; }

        [JsonProperty(PropertyName = "rx_multicast")]
        public int ReceivedMulticast { get; set; }

        [JsonProperty(PropertyName = "enable")]
        public bool IsEnabled { get; set; }

        [JsonProperty(PropertyName = "dns")]
        public List<string> Dns { get; set; }
    }
}
