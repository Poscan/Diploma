<template>
  <div>
    <v-app>
      <v-card class="mx-auto max-width" outlined>
        <router-link :to="'about/' + conference.id">
          <v-card-title>
            <v-list-item two-line>
              <v-list-item-avatar size="50">
                <img :src="conference.pictureUrl" />
              </v-list-item-avatar>
              <v-list-item-content>
                <v-list-item-title class="text-h6 mb-1">
                  {{ conference.name }}
                </v-list-item-title>
                <v-list-item-subtitle>
                  {{ conference.organisationName }}
                </v-list-item-subtitle>
              </v-list-item-content>
            </v-list-item>
          </v-card-title>
        </router-link>

        <v-divider class="line" />

        <v-card-subtitle class="mhor-16">
          <div v-html="conference.description" />
        </v-card-subtitle>

        <v-divider class="line2" />

        <v-card-actions class="mleft-24">
          <v-icon>mdi-account-multiple</v-icon>
          <div class="count">
            {{ conference.countParticipants }}
          </div>
          <v-btn class="sign-up" color="primary"> Подать заявку </v-btn>
        </v-card-actions>
      </v-card>
    </v-app>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Conference from "@/services/models/Conference";

export default Vue.extend({
  props: {
    conference: Conference,
  },
});
</script>
