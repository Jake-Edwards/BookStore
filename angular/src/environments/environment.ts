import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'PhoneBookDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44378',
    redirectUri: baseUrl,
    clientId: 'PhoneBookDemo_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone PhoneBookDemo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44348',
      rootNamespace: 'PhoneBookDemo',
    },
  },
} as Environment;
