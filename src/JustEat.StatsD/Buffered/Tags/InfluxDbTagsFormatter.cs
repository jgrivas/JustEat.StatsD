namespace JustEat.StatsD.Buffered.Tags
{
    /// <summary>
    /// Formats StatsD tags for InfluxDB.
    /// Tags placed right after the bucket name with format: "," + tag1=value1,tag2,tag3=value
    /// </summary>
    public sealed class InfluxDbTagsFormatter : StatsDTagsFormatter
    {
        private const string Prefix = ",";
        private const bool AreBucketNameTags = true;
        private const string TagsSeparator = ",";
        private const string KeyValueSeparator = "=";

        /// <summary>
        /// Initializes a new instance of the <see cref="InfluxDbTagsFormatter"/> class.
        /// </summary>
        public InfluxDbTagsFormatter()
            : base(Prefix, string.Empty, AreBucketNameTags, TagsSeparator, KeyValueSeparator)
        {
        }
    }
}
