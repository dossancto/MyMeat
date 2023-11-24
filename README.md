# MyMeat
Uma simples API REST para cadastro de carnes

## Dependencies

- Dotnet ef 
    ```sh
    dotnet tool install --global dotnet-ef --version 7.0.12
    ```

## Run

- Clone the repo 
    ```sh
    git clone https://github.com/lu-css/MyMeat
    ```

- Start MySQL on docker compose
    ```sh
    docker compose up -d
    ```

- Run migrations
    ```sh
    dotnet ef database update -s MyMeat.UI
    ```

- Launch Application
    ```sh
    dotnet run --project MyMeat.UI
    ```

