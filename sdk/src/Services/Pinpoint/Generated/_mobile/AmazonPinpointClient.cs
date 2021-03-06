/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Pinpoint.Model;
using Amazon.Pinpoint.Model.Internal.MarshallTransformations;
using Amazon.Pinpoint.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Implementation for accessing Pinpoint
    ///
    /// Amazon Pinpoint
    /// </summary>
    public partial class AmazonPinpointClient : AmazonServiceClient, IAmazonPinpoint
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPinpointClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig()) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AmazonPinpointConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointClient(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials and an
        /// AmazonPinpointClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AWSCredentials credentials, AmazonPinpointConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCampaign

        internal virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateExportJob

        internal virtual CreateExportJobResponse CreateExportJob(CreateExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateExportJobResponse> CreateExportJobAsync(CreateExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateImportJob

        internal virtual CreateImportJobResponse CreateImportJob(CreateImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateImportJobResponse> CreateImportJobAsync(CreateImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSegment

        internal virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSegmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAdmChannel

        internal virtual DeleteAdmChannelResponse DeleteAdmChannel(DeleteAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteAdmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAdmChannelResponse> DeleteAdmChannelAsync(DeleteAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAdmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsChannel

        internal virtual DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsChannelResponse> DeleteApnsChannelAsync(DeleteApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsSandboxChannel

        internal virtual DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsSandboxChannelResponse> DeleteApnsSandboxChannelAsync(DeleteApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsVoipChannel

        internal virtual DeleteApnsVoipChannelResponse DeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsVoipChannelResponse> DeleteApnsVoipChannelAsync(DeleteApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsVoipChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsVoipSandboxChannel

        internal virtual DeleteApnsVoipSandboxChannelResponse DeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsVoipSandboxChannelResponse> DeleteApnsVoipSandboxChannelAsync(DeleteApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsVoipSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBaiduChannel

        internal virtual DeleteBaiduChannelResponse DeleteBaiduChannel(DeleteBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteBaiduChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBaiduChannelResponse> DeleteBaiduChannelAsync(DeleteBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBaiduChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCampaign

        internal virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailChannel

        internal virtual DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEmailChannelResponse> DeleteEmailChannelAsync(DeleteEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventStream

        internal virtual DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEventStreamResponse> DeleteEventStreamAsync(DeleteEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGcmChannel

        internal virtual DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteGcmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteGcmChannelResponse> DeleteGcmChannelAsync(DeleteGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGcmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSegment

        internal virtual DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSegmentResponse> DeleteSegmentAsync(DeleteSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSegmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSmsChannel

        internal virtual DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSmsChannelResponse> DeleteSmsChannelAsync(DeleteSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSmsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserEndpoints

        internal virtual DeleteUserEndpointsResponse DeleteUserEndpoints(DeleteUserEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteUserEndpointsResponse> DeleteUserEndpointsAsync(DeleteUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceChannel

        internal virtual DeleteVoiceChannelResponse DeleteVoiceChannel(DeleteVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteVoiceChannelResponse> DeleteVoiceChannelAsync(DeleteVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAdmChannel

        internal virtual GetAdmChannelResponse GetAdmChannel(GetAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return Invoke<GetAdmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAdmChannelResponse> GetAdmChannelAsync(GetAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApnsChannel

        internal virtual GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsChannelResponse> GetApnsChannelAsync(GetApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApnsSandboxChannel

        internal virtual GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsSandboxChannelResponse> GetApnsSandboxChannelAsync(GetApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApnsVoipChannel

        internal virtual GetApnsVoipChannelResponse GetApnsVoipChannel(GetApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsVoipChannelResponse> GetApnsVoipChannelAsync(GetApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsVoipChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApnsVoipSandboxChannel

        internal virtual GetApnsVoipSandboxChannelResponse GetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsVoipSandboxChannelResponse> GetApnsVoipSandboxChannelAsync(GetApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsVoipSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApp

        internal virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationSettings

        internal virtual GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApplicationSettingsResponse> GetApplicationSettingsAsync(GetApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApps

        internal virtual GetAppsResponse GetApps(GetAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return Invoke<GetAppsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAppsResponse> GetAppsAsync(GetAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBaiduChannel

        internal virtual GetBaiduChannelResponse GetBaiduChannel(GetBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<GetBaiduChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBaiduChannelResponse> GetBaiduChannelAsync(GetBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetBaiduChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaign

        internal virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignActivities

        internal virtual GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return Invoke<GetCampaignActivitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignActivitiesResponse> GetCampaignActivitiesAsync(GetCampaignActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaigns

        internal virtual GetCampaignsResponse GetCampaigns(GetCampaignsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignsResponse> GetCampaignsAsync(GetCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignVersion

        internal virtual GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignVersionResponse> GetCampaignVersionAsync(GetCampaignVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignVersions

        internal virtual GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignVersionsResponse> GetCampaignVersionsAsync(GetCampaignVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannels

        internal virtual GetChannelsResponse GetChannels(GetChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return Invoke<GetChannelsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetChannelsResponse> GetChannelsAsync(GetChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEmailChannel

        internal virtual GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return Invoke<GetEmailChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEmailChannelResponse> GetEmailChannelAsync(GetEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEndpoint

        internal virtual GetEndpointResponse GetEndpoint(GetEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEndpointResponse> GetEndpointAsync(GetEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventStream

        internal virtual GetEventStreamResponse GetEventStream(GetEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEventStreamResponse> GetEventStreamAsync(GetEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExportJob

        internal virtual GetExportJobResponse GetExportJob(GetExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetExportJobResponse> GetExportJobAsync(GetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExportJobs

        internal virtual GetExportJobsResponse GetExportJobs(GetExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetExportJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetExportJobsResponse> GetExportJobsAsync(GetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGcmChannel

        internal virtual GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return Invoke<GetGcmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGcmChannelResponse> GetGcmChannelAsync(GetGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetGcmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImportJob

        internal virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImportJobs

        internal virtual GetImportJobsResponse GetImportJobs(GetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetImportJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetImportJobsResponse> GetImportJobsAsync(GetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegment

        internal virtual GetSegmentResponse GetSegment(GetSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentResponse> GetSegmentAsync(GetSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentExportJobs

        internal virtual GetSegmentExportJobsResponse GetSegmentExportJobs(GetSegmentExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentExportJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentExportJobsResponse> GetSegmentExportJobsAsync(GetSegmentExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentImportJobs

        internal virtual GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentImportJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentImportJobsResponse> GetSegmentImportJobsAsync(GetSegmentImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegments

        internal virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentVersion

        internal virtual GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentVersionResponse> GetSegmentVersionAsync(GetSegmentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentVersions

        internal virtual GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentVersionsResponse> GetSegmentVersionsAsync(GetSegmentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSmsChannel

        internal virtual GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return Invoke<GetSmsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSmsChannelResponse> GetSmsChannelAsync(GetSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetSmsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserEndpoints

        internal virtual GetUserEndpointsResponse GetUserEndpoints(GetUserEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetUserEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUserEndpointsResponse> GetUserEndpointsAsync(GetUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceChannel

        internal virtual GetVoiceChannelResponse GetVoiceChannel(GetVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<GetVoiceChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetVoiceChannelResponse> GetVoiceChannelAsync(GetVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PhoneNumberValidate

        internal virtual PhoneNumberValidateResponse PhoneNumberValidate(PhoneNumberValidateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return Invoke<PhoneNumberValidateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PhoneNumberValidateResponse> PhoneNumberValidateAsync(PhoneNumberValidateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return InvokeAsync<PhoneNumberValidateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEvents

        internal virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEventStream

        internal virtual PutEventStreamResponse PutEventStream(PutEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return Invoke<PutEventStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEventStreamResponse> PutEventStreamAsync(PutEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAttributes

        internal virtual RemoveAttributesResponse RemoveAttributes(RemoveAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<RemoveAttributesResponse> RemoveAttributesAsync(RemoveAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendMessages

        internal virtual SendMessagesResponse SendMessages(SendMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return Invoke<SendMessagesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendMessagesResponse> SendMessagesAsync(SendMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendUsersMessages

        internal virtual SendUsersMessagesResponse SendUsersMessages(SendUsersMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return Invoke<SendUsersMessagesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendUsersMessagesResponse> SendUsersMessagesAsync(SendUsersMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<SendUsersMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAdmChannel

        internal virtual UpdateAdmChannelResponse UpdateAdmChannel(UpdateAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateAdmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAdmChannelResponse> UpdateAdmChannelAsync(UpdateAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAdmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsChannel

        internal virtual UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsChannelResponse> UpdateApnsChannelAsync(UpdateApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsSandboxChannel

        internal virtual UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsSandboxChannelResponse> UpdateApnsSandboxChannelAsync(UpdateApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsVoipChannel

        internal virtual UpdateApnsVoipChannelResponse UpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsVoipChannelResponse> UpdateApnsVoipChannelAsync(UpdateApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsVoipChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsVoipSandboxChannel

        internal virtual UpdateApnsVoipSandboxChannelResponse UpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipSandboxChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsVoipSandboxChannelResponse> UpdateApnsVoipSandboxChannelAsync(UpdateApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsVoipSandboxChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationSettings

        internal virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApplicationSettingsResponse> UpdateApplicationSettingsAsync(UpdateApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBaiduChannel

        internal virtual UpdateBaiduChannelResponse UpdateBaiduChannel(UpdateBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateBaiduChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateBaiduChannelResponse> UpdateBaiduChannelAsync(UpdateBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBaiduChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCampaign

        internal virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEmailChannel

        internal virtual UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEmailChannelResponse> UpdateEmailChannelAsync(UpdateEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEmailChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointsBatch

        internal virtual UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointsBatchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEndpointsBatchResponse> UpdateEndpointsBatchAsync(UpdateEndpointsBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointsBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGcmChannel

        internal virtual UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateGcmChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateGcmChannelResponse> UpdateGcmChannelAsync(UpdateGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGcmChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSegment

        internal virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return Invoke<UpdateSegmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSegmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSmsChannel

        internal virtual UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSmsChannelResponse> UpdateSmsChannelAsync(UpdateSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSmsChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVoiceChannel

        internal virtual UpdateVoiceChannelResponse UpdateVoiceChannel(UpdateVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateVoiceChannelResponse> UpdateVoiceChannelAsync(UpdateVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVoiceChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}