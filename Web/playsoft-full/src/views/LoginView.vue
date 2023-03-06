<template>
  <div class="about">
    <CabeceraPlaysoft></CabeceraPlaysoft>
    <LoginCard></LoginCard>
  </div>
</template>

<script>
  import LoginCard from '../components/LoginCard.vue'
  import CabeceraPlaysoft from '../components/CabeceraPlaysoft.vue'

  export default{
    name: 'AboutPage',
    components:{
      CabeceraPlaysoft, LoginCard
    }
  }
</script>
