﻿namespace Microsoft.Extensions.Configuration.Yaml
{
    /// <summary>
    ///     Represents a YAML file as an <see cref="T:Microsoft.Extensions.Configuration.IConfigurationSource" />.
    /// </summary>
    public class YamlConfigurationSource : FileConfigurationSource
    {
        /// <summary>
        ///     Builds the <see cref="YamlConfigurationProvider"/> for this source.
        /// </summary>
        /// <param name="builder">
        ///     The <see cref="IConfigurationBuilder"/>.
        /// </param>
        /// <returns>
        ///     A <see cref="YamlConfigurationProvider"/>.
        /// </returns>
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new YamlConfigurationProvider(this);
        }
    }
}
