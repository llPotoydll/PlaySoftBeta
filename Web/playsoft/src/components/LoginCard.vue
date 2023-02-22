<template>
    <v-app id="inspire">
       <v-content>
          <v-container fluid fill-height>
             <v-layout align-center justify-center>
                <v-flex xs12 sm8 md4>
                   <v-card class="elevation-12">
                      <v-toolbar dark color="rgb(118, 9, 113)">
                         <v-toolbar-title>Register form</v-toolbar-title>
                      </v-toolbar>
                      <v-card-text>
                         <v-form>
                            <v-text-field
                               name="email"
                               label="Email"
                               type="email"
                            ></v-text-field>
                            <v-text-field
                               id="username"
                               name="username"
                               label="Username"
                               type="text"
                            ></v-text-field>
                            <v-text-field
                               name="pass"
                               label="Password"
                               type="password"
                            ></v-text-field>
                            <v-text-field
                               name="pass2"
                               label="Password"
                               type="password"
                            ></v-text-field>
                         </v-form>
                      </v-card-text>
                      <v-card-actions>
                         <v-spacer></v-spacer>
                         <v-btn color="rgb(118, 9, 113)" style="color: aliceblue;" to="/">Login</v-btn>
                      </v-card-actions>
                   </v-card>
                </v-flex>
             </v-layout>
          </v-container>
       </v-content>
    </v-app>
 </template>
 
 <script>
 export default {
    name: 'LoginCard',
    props: {
       source: String,
    },
 };
 </script>
 
 <style>
.v-toolbar__content{
   justify-content: center;
}
</style>
 