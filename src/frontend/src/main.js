import { createApp } from 'vue'
import { createRouter, createWebHistory } from 'vue-router'

import App from './App.vue'
import IndexView from './views/IndexView.vue'

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', component: IndexView },
    ]
});

const app = createApp(App)
app.use(router)
app.mount('#app')
