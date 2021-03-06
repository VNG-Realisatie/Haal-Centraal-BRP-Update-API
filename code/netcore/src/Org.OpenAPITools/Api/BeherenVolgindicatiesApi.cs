/*
 * BRP Update API
 *
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBeherenVolgindicatiesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon
        /// </summary>
        /// <remarks>
        /// Vraag een volgindicatie op van een specifieke persoon. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <returns>VolgindicatieRaadplegen</returns>
        VolgindicatieRaadplegen GetVolgindicatie(Object burgerservicenummer);

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon
        /// </summary>
        /// <remarks>
        /// Vraag een volgindicatie op van een specifieke persoon. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <returns>ApiResponse of VolgindicatieRaadplegen</returns>
        ApiResponse<VolgindicatieRaadplegen> GetVolgindicatieWithHttpInfo(Object burgerservicenummer);
        /// <summary>
        /// Raadpleeg actieve volgindicaties
        /// </summary>
        /// <remarks>
        /// Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VolgindicatieCollectie</returns>
        VolgindicatieCollectie GetVolgindicaties();

        /// <summary>
        /// Raadpleeg actieve volgindicaties
        /// </summary>
        /// <remarks>
        /// Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VolgindicatieCollectie</returns>
        ApiResponse<VolgindicatieCollectie> GetVolgindicatiesWithHttpInfo();
        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie
        /// </summary>
        /// <remarks>
        /// Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <returns>VolgindicatieRaadplegen</returns>
        VolgindicatieRaadplegen UpsertVolgindicatie(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie));

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie
        /// </summary>
        /// <remarks>
        /// Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <returns>ApiResponse of VolgindicatieRaadplegen</returns>
        ApiResponse<VolgindicatieRaadplegen> UpsertVolgindicatieWithHttpInfo(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBeherenVolgindicatiesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon
        /// </summary>
        /// <remarks>
        /// Vraag een volgindicatie op van een specifieke persoon. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieRaadplegen</returns>
        System.Threading.Tasks.Task<VolgindicatieRaadplegen> GetVolgindicatieAsync(Object burgerservicenummer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon
        /// </summary>
        /// <remarks>
        /// Vraag een volgindicatie op van een specifieke persoon. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieRaadplegen)</returns>
        System.Threading.Tasks.Task<ApiResponse<VolgindicatieRaadplegen>> GetVolgindicatieWithHttpInfoAsync(Object burgerservicenummer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Raadpleeg actieve volgindicaties
        /// </summary>
        /// <remarks>
        /// Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieCollectie</returns>
        System.Threading.Tasks.Task<VolgindicatieCollectie> GetVolgindicatiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Raadpleeg actieve volgindicaties
        /// </summary>
        /// <remarks>
        /// Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieCollectie)</returns>
        System.Threading.Tasks.Task<ApiResponse<VolgindicatieCollectie>> GetVolgindicatiesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie
        /// </summary>
        /// <remarks>
        /// Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieRaadplegen</returns>
        System.Threading.Tasks.Task<VolgindicatieRaadplegen> UpsertVolgindicatieAsync(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie
        /// </summary>
        /// <remarks>
        /// Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieRaadplegen)</returns>
        System.Threading.Tasks.Task<ApiResponse<VolgindicatieRaadplegen>> UpsertVolgindicatieWithHttpInfoAsync(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBeherenVolgindicatiesApi : IBeherenVolgindicatiesApiSync, IBeherenVolgindicatiesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BeherenVolgindicatiesApi : IBeherenVolgindicatiesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BeherenVolgindicatiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BeherenVolgindicatiesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeherenVolgindicatiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BeherenVolgindicatiesApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeherenVolgindicatiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BeherenVolgindicatiesApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeherenVolgindicatiesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BeherenVolgindicatiesApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon Vraag een volgindicatie op van een specifieke persoon. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <returns>VolgindicatieRaadplegen</returns>
        public VolgindicatieRaadplegen GetVolgindicatie(Object burgerservicenummer)
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> localVarResponse = GetVolgindicatieWithHttpInfo(burgerservicenummer);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon Vraag een volgindicatie op van een specifieke persoon. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <returns>ApiResponse of VolgindicatieRaadplegen</returns>
        public Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> GetVolgindicatieWithHttpInfo(Object burgerservicenummer)
        {
            // verify the required parameter 'burgerservicenummer' is set
            if (burgerservicenummer == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'burgerservicenummer' when calling BeherenVolgindicatiesApi->GetVolgindicatie");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("burgerservicenummer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(burgerservicenummer)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<VolgindicatieRaadplegen>("/volgindicaties/{burgerservicenummer}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVolgindicatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon Vraag een volgindicatie op van een specifieke persoon. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieRaadplegen</returns>
        public async System.Threading.Tasks.Task<VolgindicatieRaadplegen> GetVolgindicatieAsync(Object burgerservicenummer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> localVarResponse = await GetVolgindicatieWithHttpInfoAsync(burgerservicenummer, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg een volgindicatie op een persoon Vraag een volgindicatie op van een specifieke persoon. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieRaadplegen)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen>> GetVolgindicatieWithHttpInfoAsync(Object burgerservicenummer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'burgerservicenummer' is set
            if (burgerservicenummer == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'burgerservicenummer' when calling BeherenVolgindicatiesApi->GetVolgindicatie");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("burgerservicenummer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(burgerservicenummer)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VolgindicatieRaadplegen>("/volgindicaties/{burgerservicenummer}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVolgindicatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Raadpleeg actieve volgindicaties Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VolgindicatieCollectie</returns>
        public VolgindicatieCollectie GetVolgindicaties()
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieCollectie> localVarResponse = GetVolgindicatiesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg actieve volgindicaties Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VolgindicatieCollectie</returns>
        public Org.OpenAPITools.Client.ApiResponse<VolgindicatieCollectie> GetVolgindicatiesWithHttpInfo()
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<VolgindicatieCollectie>("/volgindicaties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVolgindicaties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Raadpleeg actieve volgindicaties Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieCollectie</returns>
        public async System.Threading.Tasks.Task<VolgindicatieCollectie> GetVolgindicatiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieCollectie> localVarResponse = await GetVolgindicatiesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg actieve volgindicaties Vraag de actieve volgindicaties op van een abonnee. Levert geen volgindicaties met einddatum vandaag of in het verleden. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieCollectie)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<VolgindicatieCollectie>> GetVolgindicatiesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VolgindicatieCollectie>("/volgindicaties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVolgindicaties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <returns>VolgindicatieRaadplegen</returns>
        public VolgindicatieRaadplegen UpsertVolgindicatie(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie))
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> localVarResponse = UpsertVolgindicatieWithHttpInfo(burgerservicenummer, volgindicatie);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <returns>ApiResponse of VolgindicatieRaadplegen</returns>
        public Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> UpsertVolgindicatieWithHttpInfo(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie))
        {
            // verify the required parameter 'burgerservicenummer' is set
            if (burgerservicenummer == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'burgerservicenummer' when calling BeherenVolgindicatiesApi->UpsertVolgindicatie");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/hal+json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("burgerservicenummer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(burgerservicenummer)); // path parameter
            localVarRequestOptions.Data = volgindicatie;


            // make the HTTP request
            var localVarResponse = this.Client.Put<VolgindicatieRaadplegen>("/volgindicaties/{burgerservicenummer}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertVolgindicatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VolgindicatieRaadplegen</returns>
        public async System.Threading.Tasks.Task<VolgindicatieRaadplegen> UpsertVolgindicatieAsync(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen> localVarResponse = await UpsertVolgindicatieWithHttpInfoAsync(burgerservicenummer, volgindicatie, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Plaats, wijzig of beëindig een volgindicatie Plaats, wijzig of beëindig een volgindicatie op een specifieke persoon. Als je de persoon nog niet volgt, wordt een volgindicatie geplaatst. Als je de persoon al wel volgt, wordt de volgindicatie gewijzigd. Verwijder de einddatum van een volgindicatie door in de request body een leeg object { } te sturen. Beëindig een volgindicatie door een einddatum gelijk aan de datum van vandaag te sturen. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="burgerservicenummer">Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.</param>
        /// <param name="volgindicatie"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VolgindicatieRaadplegen)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<VolgindicatieRaadplegen>> UpsertVolgindicatieWithHttpInfoAsync(Object burgerservicenummer, Volgindicatie volgindicatie = default(Volgindicatie), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'burgerservicenummer' is set
            if (burgerservicenummer == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'burgerservicenummer' when calling BeherenVolgindicatiesApi->UpsertVolgindicatie");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "application/hal+json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("burgerservicenummer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(burgerservicenummer)); // path parameter
            localVarRequestOptions.Data = volgindicatie;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<VolgindicatieRaadplegen>("/volgindicaties/{burgerservicenummer}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertVolgindicatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
