FROM trion/ng-cli-karma:7.1.0 as test
WORKDIR /src
COPY ./src /src
RUN yarn install --silent
RUN yarn test --watch false

FROM test as build
WORKDIR /src
COPY --from=test /src /src
RUN yarn build --prod --output-path=dist

FROM nginx:1.15.5-alpine as final
EXPOSE 80
## Copy default nginx config
COPY nginx/default.conf /etc/nginx/conf.d/
RUN chown -R nginx /etc/nginx
## Remove default nginx website
RUN rm -rf /usr/share/nginx/html/*
COPY --from=build /src/dist /usr/share/nginx/html/
CMD ["nginx", "-g", "daemon off;"]





