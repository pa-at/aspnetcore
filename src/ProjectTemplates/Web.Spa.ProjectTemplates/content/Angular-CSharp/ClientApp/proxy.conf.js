const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast/**",
//#if (IndividualLocalAuth)
      "/_configuration/**",
      "/.well-known/**",
      "/Identity/**",
      "/connect/**",
      "/ApplyDatabaseMigrations/**",
//#endif
   ],
    target: "https://localhost:5001",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
