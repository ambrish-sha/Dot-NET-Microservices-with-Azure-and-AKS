// src/environments/environment.ts
// export const environment = {
//   production: false,
//   usersAPIURL: 'https://harsha-ecommerce-api3.azure-api.net/gateway/users/',
//   productsAPIURL: 'https://harsha-ecommerce-api3.azure-api.net/gateway/products/',
//   ordersAPIURL: 'https://harsha-ecommerce-api3.azure-api.net/gateway/orders/',
//   gatewayURL: 'https://harsha-ecommerce-api3.azure-api.net/gateway/',
// };


// production: false,
//   usersAPIURL: 'http://localhost:4000/gateway/users/',
//   productsAPIURL: 'http://localhost:4000/gateway/products/',
//   ordersAPIURL: 'http://localhost:4000/gateway/orders/',
//   gatewayURL: 'http://localhost:4000/gateway/',


// src/environments/environment.ts
export const b2c = {
  tenantName: 'harshawebuniversity',
  clientId: '05f9093d-a8df-4170-86ec-4199d3d8d273',
  apiInstanceName: 'harsha-ecommerce-api3'
};

const serverUrl = 'https://harsha-ecommerce-api3.azure-api.net/';

export const environment = {
  production: false,
  usersAPIURL: `https://${b2c.apiInstanceName}.azure-api.net/gateway/users/`,
  productsAPIURL: `https://${b2c.apiInstanceName}.azure-api.net/gateway/products/`,
  ordersAPIURL: `https://${b2c.apiInstanceName}.azure-api.net/gateway/orders/`,
  gatewayURL: `https://${b2c.apiInstanceName}.azure-api.net/gateway/`,

  config: {
    env_name: 'dev',
    production: true,
    apiUrl: serverUrl,
    apiEndpoints: {
      userProfile:'user-profiles'
    },
    adb2cConfig: {
      clientId: b2c.clientId,
      scopeUrls:[
        `https://${b2c.tenantName}.onmicrosoft.com/ecommerce/access_as_user`
      ],
      apiEndpointUrls: [ 
        `${serverUrl}gateway/users`, 
        `${serverUrl}gateway/orders`,
        `${serverUrl}gateway/products`
      ],
      b2clogin: `${b2c.tenantName}.b2clogin.com`,
      authorityDomain: `${b2c.tenantName}.onmicrosoft.com`,
      signUpUserFlow: 'B2C_1_SignUp'
    },
    cacheTimeInMinutes: 30,
  }
};
