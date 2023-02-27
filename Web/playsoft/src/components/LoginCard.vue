<template>
   <v-app id="inspire">
      <v-content>
         <v-container class="fill-height" fluid>
            <v-row align="center" justify="center">
               <v-col cols="12" sm="8" md="8">
                  <v-card class="elevation-12">
                     <v-window v-model="step">
                        <v-window-item :value="1">
                           <v-row>
                              <v-col cols="12" md="8">
                                 <v-card-text class="mt-12">
                                    <h1  style="color: #6c176d;">Sign in to PlaySoft</h1>
                                    <v-form>
                                       <v-text-field label="Email" name="Email" type="text"
                                          color="#6c176d" />

                                       <v-text-field id="password" label="Password" name="password" 
                                          type="password" color="#6c176d" />
                                    </v-form>
                                    <h3 class="text-center mt-4">Forgot your password ?</h3>
                                 </v-card-text>
                                 <div class="text-center mt-3">
                                    <v-btn rounded color="#6c176d" dark>SIGN IN</v-btn>
                                 </div>
                              </v-col>
                              <v-col cols="12" md="4" style="background-color: #6c176d;">
                                 <v-card-text class="white--text mt-12">
                                    <h1 class="text-center display-1" style="color: white;">Hello, Friend!</h1>
                                    <h5 class="text-center">Don't have an account? Create now!</h5>
                                 </v-card-text>
                                 <div class="text-center">
                                    <v-btn rounded outlined dark @click="step++">SIGN UP</v-btn>
                                 </div>
                              </v-col>
                           </v-row>
                        </v-window-item>
                        <v-window-item :value="2">
                           <v-row class="fill-height">
                              <v-col cols="12" md="4" style="background-color: #6c176d;">
                                 <v-card-text class="white--text mt-12">
                                    <h5 class="text-center">Do you have an account? Sign in now!
                                    </h5>
                                 </v-card-text>
                                 <div class="text-center">
                                    <v-btn rounded outlined dark @click="step--">Sign in</v-btn>
                                 </div>
                              </v-col>

                              <v-col cols="12" md="8">
                                 <v-card-text class="mt-12">
                                    <h1 >Create Account</h1>
                                    <v-form>
                                       <v-text-field label="Name" name="Name" type="text" color="#6c176d" />
                                       <v-text-field label="Email" name="Email" type="text" color="#6c176d" />

                                       <v-text-field id="password" label="Password" name="password" type="password"
                                          color="#6c176d" />
                                    </v-form>
                                 </v-card-text>
                                 <div class="text-center mt-n5">
                                    <v-btn rounded color="#6c176d" dark>SIGN UP</v-btn>
                                 </div>
                              </v-col>
                           </v-row>
                        </v-window-item>
                     </v-window>
                  </v-card>
               </v-col>
            </v-row>
         </v-container>
      </v-content>
   </v-app>
</template>

<script>
export default {
   data: () => ({
      step: 1
   }),
   props: {
      source: String
   }
};
</script>

<style>
</style>