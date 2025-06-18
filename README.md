# GameStore
Aplikacja webowa napisana w ASP.NET, która symuluje storne sklepu internetowego z grami. 
Projekt składa się z dwóch głównych części:
- **GameStore.API** – backend (API), obsługujący logikę aplikacji i zarządzający danymi.
- **GameStore.Frontend** – frontend, zapewniający interfejs użytkownika do przeglądania i zarządzania grami.

## Instalacja
### Backend (.NET API)
1. **Sklonuj repozytorium**:
   git clone https://github.com/username/GameStore.git

2. **Przejdź do katalogu projektu backendowego**:
   cd GameStore.API

3. **Przygotuj bazę danych**:
   - Utwórz bazę danych `game_store` w SQL Server.
   - Zaktualizuj connection string w pliku `appsettings.json`:
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=game_store;User Id=your_username;Password=your_password;"
     }

4. **Zainstaluj zależności**:
   dotnet restore

5. **Uruchom migracje**:
   dotnet ef database update

6. **Uruchom aplikację**:
   dotnet run


### Frontend 
1. **Przejdź do katalogu projektu frontendowego**:
   cd GameStoreF
   
3. **Uruchom aplikację**:
    dotnet run


## Funkcjonalności
- **Przeglądanie listy gier** – użytkownicy mogą przeglądać dostępne gry.
- **Zarządzanie grami** – możliwość dodawania, edytowania i usuwania gier.
- **Koszyk** – użytkownicy mogą dodawać gry do koszyka i finalizować zakup.
- **Interfejs użytkownika** – wygodny frontend pozwalający na interakcję z API.

