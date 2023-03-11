<template>
    <div>
        <CabeceraPlaysoft></CabeceraPlaysoft>
        <SongListado></SongListado>
    </div>
</template>

<script>
import CabeceraPlaysoft from '@/components/CabeceraPlaysoft.vue';
import SongListado from '@/components/SongListado.vue';

export default {
    name: 'HomeView',
    components: {
        CabeceraPlaysoft, SongListado
    }
}
</script>