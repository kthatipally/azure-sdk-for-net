﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary>
    /// Extension methods to add <see cref="FormRecognizerClient"/> and <see cref="DocumentAnalysisClient"/> clients
    /// to clients builder.
    /// </summary>
    public static class FormRecognizerClientBuilderExtensions
    {
        /// <summary>
        /// Registers a <see cref="DocumentAnalysisClient"/> instance with the provided <paramref name="endpoint"/>.
        /// </summary>
        public static IAzureClientBuilder<DocumentAnalysisClient, DocumentAnalysisClientOptions> AddDocumentAnalysisClient<TBuilder>(this TBuilder builder, Uri endpoint)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DocumentAnalysisClient, DocumentAnalysisClientOptions>((options, credential) => new DocumentAnalysisClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="DocumentAnalysisClient"/> instance with the provided <paramref name="endpoint"/> and <paramref name="credential"/>.
        /// </summary>
        public static IAzureClientBuilder<DocumentAnalysisClient, DocumentAnalysisClientOptions> AddDocumentAnalysisClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
            where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<DocumentAnalysisClient, DocumentAnalysisClientOptions>(options => new DocumentAnalysisClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="DocumentAnalysisClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        public static IAzureClientBuilder<DocumentAnalysisClient, DocumentAnalysisClientOptions> AddDocumentAnalysisClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DocumentAnalysisClient, DocumentAnalysisClientOptions>(configuration);
        }

        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with the provided <paramref name="endpoint"/>.
        /// </summary>
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder>(this TBuilder builder, Uri endpoint)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>((options, credential) => new FormRecognizerClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with the provided <paramref name="endpoint"/> and <paramref name="credential"/>.
        /// </summary>
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
            where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>(options => new FormRecognizerClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>(configuration);
        }
    }
}
