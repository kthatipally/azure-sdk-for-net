// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Datastore account key secrets. </summary>
    public partial class AccountKeyDatastoreSecrets : DatastoreSecrets
    {
        /// <summary> Initializes a new instance of AccountKeyDatastoreSecrets. </summary>
        public AccountKeyDatastoreSecrets()
        {
            SecretsType = SecretsType.AccountKey;
        }

        /// <summary> Initializes a new instance of AccountKeyDatastoreSecrets. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="key"> Storage account key. </param>
        internal AccountKeyDatastoreSecrets(SecretsType secretsType, string key) : base(secretsType)
        {
            Key = key;
            SecretsType = secretsType;
        }

        /// <summary> Storage account key. </summary>
        public string Key { get; set; }
    }
}
