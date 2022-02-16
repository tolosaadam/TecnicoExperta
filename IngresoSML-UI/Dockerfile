FROM node:14.17.5-alpine
#Create app directory
WORKDIR /app

COPY package.json .
RUN npm install

COPY . ./
RUN npm run build

EXPOSE 3000

CMD ["npm","start"]

