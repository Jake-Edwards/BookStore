const ENV = {
  dev: {
    apiUrl: 'http://localhost:44348',
    oAuthConfig: {
      issuer: 'http://localhost:44378',
      clientId: 'PhoneBookDemo_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access PhoneBookDemo',
    },
    localization: {
      defaultResourceName: 'PhoneBookDemo',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44348',
    oAuthConfig: {
      issuer: 'http://localhost:44378',
      clientId: 'PhoneBookDemo_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access PhoneBookDemo',
    },
    localization: {
      defaultResourceName: 'PhoneBookDemo',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
